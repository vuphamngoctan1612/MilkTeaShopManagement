using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaHouseProject.DTO;

namespace MilkTeaShopManagement.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return AccountDAL.instance; }
            private set { AccountDAL.instance = value; }
        }

        private AccountDAL() { }

        public List<Account> GetListAccount()
        {
            List<Account> accounts = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account");
            foreach(DataRow dataRow in data.Rows)
            {
                Account account = new Account(dataRow);
                accounts.Add(account);
            }
            return accounts;
        }
        public bool LoginAdmin(string userName, string passWord)
        {
            passWord = Encryptor.Instance.Encrypt(passWord);

            string query = "SELECT * FROM Account WHERE UserName = '" + userName + "' AND PassWord = '" + passWord + "' AND Type = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool LoginStaff(string userName, string passWord)
        {
            passWord = Encryptor.Instance.Encrypt(passWord);

            string query = "SELECT * FROM Account WHERE UserName = '" + userName + "' AND PassWord = '" + passWord + "' AND Type = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool Login(string username, string password)
        {
            password = Encryptor.Instance.Encrypt(password);

            string query = "SELECT * FROM Account WHERE UserName = '" + username + "' AND PassWord = '" + password + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool SignUp(string userName, string passWord)
        {
            passWord = Encryptor.Instance.Encrypt(passWord);

            try
            {
                string query = "INSERT INTO Account VALUES('" + userName + "', '" + passWord + "', 1)";

                return DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool IsExistAccount(string username)
        {
            string query = string.Format("SELECT * FROM Account WHERE USERNAME = '{0}'", username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool signUpAdmin(string username, string password)
        {
            password = Encryptor.Instance.Encrypt(password);

            try
            {
                string query = "INSERT INTO Account VALUES('" + username + "', '" + password + "', 0)";

                return DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch 
            {
                return false;
            }
        }

        public void DelAccount(string username)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM ACCOUNT WHERE USERNAME = '{0}'", username));
        }

        public void changePassword(string username, string password)
        {
            password = Encryptor.Instance.Encrypt(password);
            DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE ACCOUNT SET PASSWORD = '{0}' WHERE USERNAME = '{1}'" ,password, username));
        }
    }
}
