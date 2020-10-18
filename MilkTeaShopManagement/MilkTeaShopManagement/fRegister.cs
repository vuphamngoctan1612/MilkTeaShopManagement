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
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text;
            string passWord = this.txtPassWord.Text;
            string rePassWord = this.txtRePassWord.Text;
            if (userName == "")
            {
                MessageBox.Show("Cần nhập tên tài khoản mới!");
            } 
               
            else if (Account.Instance.checkUserName(userName))
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
            }    
            else if (passWord != rePassWord)
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu!");
            }
            else
            {
                
                if (Account.Instance.Register(userName, passWord))
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                }
            }    

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
