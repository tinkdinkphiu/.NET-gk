using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
        }

        public List<AccountDTO> GetAccountList()
        {
            string query = "SELECT * FROM Accounts";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<AccountDTO> accountList = new List<AccountDTO>();
            foreach(DataRow row in data.Rows)
            {
                AccountDTO account = new AccountDTO()
                {
                    AccountID = row["AccountID"].ToString(),
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
                accountList.Add(account);
            }
            return accountList;
        }

        public AccountDTO GetAccountByID(string accountID)
        {
            string query = "SELECT * FROM Accounts WHERE AccountID = @AccountID";
            object[] parameters = { accountID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                AccountDTO account = new AccountDTO
                {
                    AccountID = row["AccountID"].ToString(),
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
                return account;
            }
            else
            {
                return null;
            }
        }

        public AccountDTO GetAccountByUsername(string username)
        {
            string query = "SELECT * FROM Accounts WHERE Username = @Username";
            object[] parameters = { username };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                AccountDTO account = new AccountDTO
                {
                    AccountID = row["AccountID"].ToString(),
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                    // Add other account fields as needed
                };
                return account;
            }
            else
            {
                return null; // Return null if the account is not found
            }
        }

        public bool AddAccount(AccountDTO account)
        {
            string query = "INSERT INTO Accounts (Username, Password, Role) " +
                           "VALUES ( @Username , @Password , @Role )";
            object[] parameters = { account.Username, account.Password, account.Role };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateAccount(AccountDTO account)
        {
            string query = "UPDATE Accounts " +
                           "SET Password = @Password , Role = @Role " +
                           "WHERE Username = @Username ";
            object[] parameters = { account.Password, account.Role, account.Username };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = "DELETE FROM Accounts WHERE Username = @Username";
            object[] parameters = { username };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Authenticate(string username, string password)
        {
            AccountDTO account = GetAccountByUsername(username);

            if (account != null)
            {
                if (account.Password.Equals(password))
                {
                    // Đăng nhập thành công
                    SessionManager.Login(account.AccountID, account.Username, account.Role);
                    return true;
                }
            }

            // Đăng nhập thất bại
            return false;
        }

        public List<AccountDTO> SearchAccountByUsernameAndRole(string keyword)
        {
            string query = "SELECT * FROM Accounts WHERE Username LIKE @Username or Role LIKE @Role";
            object[] parameters = { "%" + keyword + "%", "%" + keyword + "%" };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<AccountDTO> result = new List<AccountDTO>();
            foreach (DataRow row in data.Rows)
            {
                AccountDTO account = new AccountDTO
                {
                    AccountID = row["AccountID"].ToString(),
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString()
                };
                result.Add(account);
            }
            return result;
        }
    }
}
