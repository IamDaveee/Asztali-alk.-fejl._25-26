using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdopontFogalals
{
    internal class Session
    {
        public static int UserId { get; private set; }
        public static string Username { get; private set; }
        public static string Mobile { get; private set; }
        public static string Email { get; private set; }
        public static bool IsLoggedIn { get; private set; }

        public static void Login(User user) //Successful login: Session.Login(user);
        {
            UserId = user.id;
            Username = user.username;
            Mobile = user.mobile;
            Email = user.email;
            IsLoggedIn = true;
        }

        public static void Logout() //Logout
        {
            UserId = 0;
            Username = null;
            Mobile = null;
            Email = null;
            IsLoggedIn = false;
        }
    }
}
