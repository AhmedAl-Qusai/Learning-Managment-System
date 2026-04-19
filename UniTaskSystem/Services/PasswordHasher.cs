using System.Security.Cryptography;

namespace UniTaskSystem.Services
{
    public static class PasswordHasher
    {
        // نستخدم out بدل tuple عشان التوافق
        public static void HashPassword(string password, out byte[] hash, out byte[] salt, out int iterations)
        {
            iterations = 100000;

            // Salt بطول 16 بايت
            salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // ملاحظة: هذه النسخة تستخدم SHA1 افتراضياً (متوافقة جداً مع .NET Framework)
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                hash = pbkdf2.GetBytes(32); // 32 bytes hash
            }
        }

        public static bool Verify(string password, byte[] salt, int iterations, byte[] expectedHash)
        {
            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                hash = pbkdf2.GetBytes(32);
            }

            if (hash.Length != expectedHash.Length) return false;

            // مقارنة ثابتة الزمن
            int diff = 0;
            for (int i = 0; i < hash.Length; i++)
                diff |= hash[i] ^ expectedHash[i];

            return diff == 0;
        }
    }
}
