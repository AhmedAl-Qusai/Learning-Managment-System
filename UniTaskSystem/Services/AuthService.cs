using System;
using System.Data;
using System.Data.SqlClient;
using UniTaskSystem.Data;

namespace UniTaskSystem.Services
{
    public class LoginResult
    {
        public bool Ok { get; set; }
        public string Role { get; set; }
        public string Identifier { get; set; }
        public int UserId { get; set; }
    }

    public class AuthService
    {
        public void RegisterByActivationCode(string code, string password)
        {
            byte[] hash, salt;
            int iters;
            PasswordHasher.HashPassword(password, out hash, out salt, out iters);

            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Auth_RegisterByActivationCode", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.Add("@PasswordHash", SqlDbType.VarBinary, 64).Value = hash;
                cmd.Parameters.Add("@PasswordSalt", SqlDbType.VarBinary, 16).Value = salt;
                cmd.Parameters.AddWithValue("@HashIterations", iters);

                cmd.Parameters.Add("@UserId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Role", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Identifier", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public LoginResult Login(string identifier, string password)
        {
            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Auth_GetUserForLogin", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identifier", identifier);

                con.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (!r.Read())
                        return new LoginResult { Ok = false };

                    int userId = Convert.ToInt32(r["UserId"]);
                    string role = (string)r["Role"];
                    string dbId = (string)r["Identifier"];
                    byte[] hash = (byte[])r["PasswordHash"];
                    byte[] salt = (byte[])r["PasswordSalt"];
                    int iters = Convert.ToInt32(r["HashIterations"]);

                    bool ok = PasswordHasher.Verify(password, salt, iters, hash);

                    return new LoginResult
                    {
                        Ok = ok,
                        Role = ok ? role : null,
                        Identifier = ok ? dbId : null,
                        UserId = ok ? userId : 0
                    };
                }
            }
        }

        public void ResetPassword(string identifier, string resetCode, string newPassword)
        {
            byte[] hash, salt;
            int iters;
            PasswordHasher.HashPassword(newPassword, out hash, out salt, out iters);

            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Auth_ResetPassword", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Identifier", identifier);
                cmd.Parameters.AddWithValue("@ResetCode", resetCode);
                cmd.Parameters.Add("@PasswordHash", SqlDbType.VarBinary, 64).Value = hash;
                cmd.Parameters.Add("@PasswordSalt", SqlDbType.VarBinary, 16).Value = salt;
                cmd.Parameters.AddWithValue("@HashIterations", iters);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CleanupResetCodes()
        {
            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Auth_CleanupResetCodes", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            byte[] hash, salt;
            int iters;

            // 1) اقرأ بيانات كلمة المرور الحالية عبر Stored Procedure
            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Auth_GetPasswordInfo", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);

                con.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (!r.Read())
                        throw new Exception("الحساب غير موجود.");

                    hash = (byte[])r["PasswordHash"];
                    salt = (byte[])r["PasswordSalt"];
                    iters = Convert.ToInt32(r["HashIterations"]);
                }
            }

            // 2) تحقق من كلمة المرور القديمة
            if (!PasswordHasher.Verify(oldPassword, salt, iters, hash))
                throw new Exception("كلمة المرور الحالية غير صحيحة.");

            // 3) أنشئ Hash/Salt/Iterations جديدة
            byte[] newHash, newSalt;
            int newIters;
            PasswordHasher.HashPassword(newPassword, out newHash, out newSalt, out newIters);

            // 4) حدّث عبر Stored Procedure
            using (SqlConnection con = Db.GetConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_Auth_UpdatePasswordByUserId", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.Add("@PasswordHash", SqlDbType.VarBinary, 64).Value = newHash;
                cmd.Parameters.Add("@PasswordSalt", SqlDbType.VarBinary, 16).Value = newSalt;
                cmd.Parameters.AddWithValue("@HashIterations", newIters);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
