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

            txtUser.Focus();
        }

        #region Method
        private void ShowError(Control control, string error)
        {
            errorShow.Visible = true;
            errorShow.Location = new Point(control.Location.X, control.Location.Y + control.Height);
            errorShow.Text = error;
        }

        private byte[] LoadImage()
        {
            string imgLocation = "./images/blank-profile.png";
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader bnr = new BinaryReader(stream);
            byte[] img = bnr.ReadBytes((int)stream.Length);
            return img;
        }
        #endregion

        #region Event
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

            if (string.IsNullOrEmpty(this.txtUser.Text))
            {
                this.txtUser.Focus();
                ShowError(this.txtUser, "Vui lòng nhập tài khoản!");
                return;
            }
            if (string.IsNullOrEmpty(this.txtPass.Text))
            {
                this.txtPass.Focus();
                ShowError(this.txtPass, "Vui lòng nhập mật khẩu!");
                return;
            }
            if (string.IsNullOrEmpty(this.txtRePass.Text))
            {
                this.txtRePass.Focus();
                ShowError(this.txtRePass, "Vui lòng nhập lại mật khẩu!");
                return;
            }

            if (this.txtRePass.Text != this.txtPass.Text)
            {
                this.txtRePass.Focus();
                ShowError(this.txtRePass, "Mật khẩu không khớp!");
                return;
            }
            if (AccountDAL.Instance.SignUp(username, password))
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Đăng ký");
                this.Close();
            }
            else
            {
                ShowError(this.txtUser, "Tài khoản đã tồn tại!");
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnSignUp_Click(sender, e);
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as Control).Text))
            {
                errorShow.Visible = false;
            }
        }
        #endregion

        private void txtRePass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as Control).Text))
            {
                errorShow.Visible = false;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as Control).Text))
            {
                errorShow.Visible = false;
            }
        }
    }
}
