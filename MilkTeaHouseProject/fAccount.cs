using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaShopManagement.DAL;

namespace MilkTeaHouseProject
{
    public partial class fAccount : Form
    {
        public fAccount(string username)
        {
            InitializeComponent();

            txtUser.Text = username;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu mới");
            }
            else if (txtRepass.Text == "")
                { 
                    MessageBox.Show("Nhập lại mật khẩu mới"); 
                }
                    else if (txtPass.Text != txtRepass.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không trùng");
                    } 
                        else
                        {
                            AccountDAL.Instance.changePassword(txtUser.Text, txtPass.Text);
                            MessageBox.Show("Đổi thành công");
                            this.Close();
                        }    
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.btnAdd_Click(sender, e);
            }
        }
    }
}
