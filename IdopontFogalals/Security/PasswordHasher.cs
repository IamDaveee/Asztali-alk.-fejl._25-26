using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdopontFogalals
{
    internal class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }

        /* //App használata
         
            string hash = PasswordHasher.HashPassword(txtPassword.Text);

            bool correct = PasswordHasher.VerifyPassword(txtPassword.Text, user.PasswordHash);

         */
    }
}
