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
                fAdmin admin = new fAdmin();
                this.Hide();
                admin.ShowDialog();
                this.Show();
            }
            else if (LoginStaff(userName, passWord))
            {
                fOrder order = new fOrder();
                this.Hide();
                order.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!", "Đăng Nhập");
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

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
