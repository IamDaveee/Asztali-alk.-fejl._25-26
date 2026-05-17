using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace IdopontFogalals
{
    internal class ValidationHelper
    {
        public static bool IsEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, pattern);
        }
    }
    /*
    //In register.form

    if (ValidationHelper.IsEmpty(username))
    {
        MessageBox.Show("Username is required.");
        return;
    }
     */
}
