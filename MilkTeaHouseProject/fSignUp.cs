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
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(this.txtUser.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên đăng nhập", "Error");
            }                
            else if(this.txtPass.Text != this.txtRePass.Text)
            {
                MessageBox.Show("Nhập lại Mật khẩu không khớp", "Error");
            }    
            else if(this.txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập Họ tên", "Error");
            }    
            else if(Account.Instance.SignUpAdmin(this.txtUser.Text, this.txtPass.Text, this.txtName.Text, this.dateTimePicker1.Value.ToString()))
            {
                MessageBox.Show("Đăng ký Tài khoản thành công");
            }    
        }
    }
}
