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

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (AccountDAL.Instance.SignUp(username, password))
                {
                    this.Close();
                }
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Focus();
                ShowError(txtUser, "Vui lòng nhập tên đăng nhập");
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Focus();
                ShowError((sender as Control), "Vui lòng nhập mật khẩu");
            }
        }

        private void txtRePass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRePass.Text))
            {
                txtRePass.Focus();
                ShowError((sender as Control), "Vui lòng nhập lại mật khẩu");
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as Control).Text))
            {
                errorShow.Visible = false;
            }
        }

        private void btnSignUp_Validating(object sender, CancelEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (password != txtRePass.Text)
            {
                ShowError(txtRePass, "Mật khẩu nhập lại sai");
            }
            else if (AccountDAL.Instance.IsExistAccount(username))
            {
                ShowError(txtUser, "Tên đăng nhập đã tồn tại");
            }
        }
        #endregion
    }
}
