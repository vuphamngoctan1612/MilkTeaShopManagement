﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void DelAccount(string username)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM ACCOUNT WHERE USERNAME = '{0}'", username));
        }
    }
}
