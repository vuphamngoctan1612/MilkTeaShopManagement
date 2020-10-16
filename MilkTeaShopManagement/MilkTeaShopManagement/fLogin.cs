using MilkTeaShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShopManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text;
            string passWord = this.txtPassWord.Text;

            if (LoginAdmin(userName, passWord)) 
            { 
                
            }
        }

        bool LoginAdmin(string userName, string passWord)
        {
            return Account.Instance.LoginAdmin(userName, passWord);
        }
        bool LoginStaff(string userName, string passWord)
        {
            return Account.Instance.LoginStaff(userName, passWord);
        }
    }
}
