using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.txtPass.UseSystemPasswordChar = true;
        }

        #region Methods
        private bool LoginAdmin(string username, string password)
        {
            return AccountDAL.Instance.LoginAdmin(username, password);
        }

        private bool LoginStaff(string username, string password)
        {
            return AccountDAL.Instance.LoginStaff(username, password);
        }

        private bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }
        #endregion

        #region Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUser.Text;
            string password = this.txtPass.Text;
            
            if (Login(username, password))
            {
                fMain f = new fMain(username);
                this.Hide();
                f.ShowDialog();
                this.Show();
                this.txtUser.Text = this.txtPass.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Error");
            }
        }

        private void lbSignup_Click(object sender, EventArgs e)
        {
            fSignUp f = new fSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.btnLogin_Click(sender, e);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.btnLogin_Click(sender, e);
            }
        }

        #endregion
    }
}
