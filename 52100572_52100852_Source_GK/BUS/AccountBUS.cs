using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        private AccountDAO accountDAO = AccountDAO.Instance;
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

        public List<AccountDTO> GetAccountList()
        {
            return accountDAO.GetAccountList();
        }

        public List<AccountDTO> Search(string key)
        {
            return accountDAO.SearchAccountByUsernameAndRole(key);
        }

        public bool AddAccount(AccountDTO account)
        {
            return accountDAO.AddAccount(account);
        }

        public bool UpdateAccount(AccountDTO updatedAccount)
        {
            // Thêm xử lý validation nếu cần
            if (string.IsNullOrEmpty(updatedAccount.Username) || string.IsNullOrEmpty(updatedAccount.Password) || string.IsNullOrEmpty(updatedAccount.Role))
            {
                // Xử lý lỗi hoặc thông báo
                return false;
            }

            return accountDAO.UpdateAccount(updatedAccount);
        }

        public bool DeleteAccount(string username)
        {
            return accountDAO.DeleteAccount(username);
        }

        public AccountDTO GetAccountByID(string xeOtoID)
        {
            return accountDAO.GetAccountByID(xeOtoID);
        }

        public AccountDTO GetAccountByUsername(string username)
        {
            return accountDAO.GetAccountByUsername(username);
        }

        public bool Login(string username, string password)
        {
            return AccountDAO.Instance.Authenticate(username, password);
        }
    }
}
