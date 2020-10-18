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
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            string rePassWord = txtRePassWord.Text;

            if (passWord != rePassWord)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Đăng Ký");
                return;
            }
            else
            {
                if (SignUp(userName, passWord))
                {
                    MessageBox.Show("Đăng Ký thành công.", "Đăng Ký");
                    this.Close();
                }
            }
        }

        bool SignUp(string userName, string passWord)
        {
            return Account.Instance.SignUp(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
