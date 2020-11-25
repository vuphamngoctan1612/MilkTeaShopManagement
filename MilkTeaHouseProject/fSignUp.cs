using MilkTeaHouseProject.DAL;
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
using System.IO;

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
            string username = txtUser.Text;
            string password = txtPass.Text;
            string name = txtName.Text;
            string pos = "Quản lí";
            DateTime birthday = dateTimePicker1.Value;
            byte[] img = LoadImage();
            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nhập tên đăng nhập", "Error");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Nhập mật khẩu", "Error");
            }
            else if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập Họ Tên", "Error");
            }
            else if (txtRePass.Text != txtPass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng", "Error");
            }
            else
            {
                AccountDAL.Instance.signUpAdmin(username, password);
                StaffDAL.Instance.AddStaff(name, img, birthday, pos, username);
                MessageBox.Show("Đăng kí thành công");
                this.Close();
            }
        }
        private byte[] LoadImage()
        {
            string imgLocation = "./images/blank-profile.png";
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader bnr = new BinaryReader(stream);
            byte[] img= bnr.ReadBytes((int)stream.Length);
            return img;
        }
    }
}
