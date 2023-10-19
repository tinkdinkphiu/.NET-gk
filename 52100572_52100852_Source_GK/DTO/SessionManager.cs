using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SessionManager
    {
        public static int UserId { get; private set; }
        public static string Username { get; private set; }
        public static string Role { get; private set; }

        public static void Login(int userId, string username, string role)
        {
            UserId = userId;
            Username = username;
            Role = role;
        }

        public static void Logout()
        {
            UserId = 0;
            Username = null;
            Role = null;
        }

        public static bool IsUserLoggedIn()
        {
            return UserId != 0;
        }
    }

}
