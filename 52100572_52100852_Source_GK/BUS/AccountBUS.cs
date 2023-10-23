using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        public bool Login(string username, string password)
        {
            return AccountDAO.Instance.Authenticate(username, password);
        }
    }
}
