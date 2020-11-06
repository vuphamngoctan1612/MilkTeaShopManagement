using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShopManagement.DAL
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
        public bool SignUpAdmin(string userName, string passWord,string name, string birthDate)
        {
            passWord = Encryptor.Instance.Encrypt(passWord);
            bool res = false;
            try
            {
                string query = "INSERT INTO Account VALUES('" + userName + "', '" + passWord + "', 0)";

                res = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch
            {
                MessageBox.Show("Tài Khoản đã tồn tại!", "Error");
            }
            string queryAdmin = "SELECT ID FROM Admin";
            DataTable dt = DataProvider.Instance.ExcuteQuery(queryAdmin);
            int newID = int.Parse(dt.Rows[dt.Rows.Count - 1].ItemArray[0].ToString()) + 1;
            string que = "INSERT INTO Admin VALUES (" + newID + ",N'" + name + "','" + birthDate + "','" + userName + "')";
            DataProvider.Instance.ExcuteQuery(que);
            return res;
        }
        public bool SignUpStaff(string userName, string passWord)
        {
            passWord = Encryptor.Instance.Encrypt(passWord);
            bool res = false;

            try
            {
                string query = "INSERT INTO Account VALUES('" + userName + "', '" + passWord + "', 1)";

                res = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch
            {
                MessageBox.Show("Tài Khoản đã tồn tại!", "Error");
            }

            return res;
        }
    }
}
