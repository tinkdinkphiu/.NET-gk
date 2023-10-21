using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SessionManager
    {
        public static string UserId { get; private set; }
        public static string Username { get; private set; }
        public static string Role { get; private set; }

        public static void Login(string userId, string username, string role)
        {
            UserId = userId;
            Username = username;
            Role = role;
        }

        public static void Logout()
        {
            UserId = null;
            Username = null;
            Role = null;
        }

        public static bool IsUserLoggedIn()
        {
            return UserId != null;
        }
    }

}
