using System;
using System.Data;
using System.Data.SqlClient;
using UniTaskSystem.Data;

namespace UniTaskSystem.Services
{
    public class StudentService
    {
        public DataTable GetStudentInfo(string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Student_GetInfo", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetUnreadDailyTasks(string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Student_GetUnreadDailyTasks", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void MarkDailyTaskAsRead(int postId, string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_PostReads_MarkRead", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetStudentCoursesByType(string studentId, string offeringType)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Student_GetCoursesByType", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@OfferingType", offeringType);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCourseHeader(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Offering_GetHeaderForStudent", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCourseTasks(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetCourseTasks", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCourseMaterials(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetCourseMaterials", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTaskDetails(int postId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetTaskDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTaskAttachments(int postId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Attachments_GetByPostBasic", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int SubmitAnswer(int postId, string studentId, string textAnswer)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Submissions_SubmitAnswer", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@TextAnswer", (object)textAnswer ?? DBNull.Value);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AddSubmissionAttachment(int submissionId, string fileName, string filePath, string mimeType, long sizeBytes)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_SubmissionAttachments_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubmissionId", submissionId);
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@FilePath", filePath);
                cmd.Parameters.AddWithValue("@MimeType", (object)mimeType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FileSizeBytes", sizeBytes);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetStudentSubmission(int postId, string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Submissions_GetStudentSubmission", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSubmissionAttachments(int submissionId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_SubmissionAttachments_GetBySubmission", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubmissionId", submissionId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTermWork(string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Student_GetTermWork", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetLecturePlanForStudent(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_LecturePlan_GetForStudent", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetPlanStatsForStudent(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_LecturePlan_GetStats", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetWeeklyAchievements(string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Student_GetWeeklyAchievements", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSyllabusPosts(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetSyllabusPosts", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetModelPosts(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetModelPosts", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetPostAttachments(int postId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Attachments_GetByPostDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAdminNotifications()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_AdminNotifications_GetAll", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void DeleteSubmission(int submissionId, string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Submissions_DeleteByStudent", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubmissionId", submissionId);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
