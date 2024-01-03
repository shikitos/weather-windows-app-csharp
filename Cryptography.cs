using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class Cryptography
    {
        public static string GenerateSaltedHash(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string saltedPassword = String.Concat(password, salt);

                byte[] saltedHashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));

                return Convert.ToBase64String(saltedHashBytes);
            }
        }

        public static string GenerateSalt()
        {
            byte[] randomBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }

        public static bool VerifyPassword(string inputPassword, string storedHash, string storedSalt)
        {
            string newHash = GenerateSaltedHash(inputPassword, storedSalt);

            return newHash == storedHash;
        }
    }
}
