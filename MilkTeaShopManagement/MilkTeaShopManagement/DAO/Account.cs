using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShopManagement.DAO
{
    public class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return Account.instance; }
            private set { Account.instance = value; }
        }

        private Account() { }

        public bool LoginAdmin(string userName, string passWord)
        {
            passWord = Encryptor.Instance.Encrypt(passWord);

            string query = "SELECT * FROM Account WHERE UserName = '" + userName + "' AND PassWord = '" + passWord + "' AND Type = 0";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }
        public bool LoginStaff(string userName, string passWord)
        {
            passWord = Encryptor.Instance.Encrypt(passWord);

            string query = "SELECT * FROM Account WHERE UserName = '" + userName + "' AND PassWord = '" + passWord + "' AND Type = 1";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
