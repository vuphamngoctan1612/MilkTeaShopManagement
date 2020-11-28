using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class fEditStaff : Form
    {
        public fEditStaff(int ID, string name, DateTime BirthDate, string pos, string phonenumber)
        {
            InitializeComponent();
            this.lbIdIncrease.Text = ID.ToString();
            this.txtName.Text = name;
            this.dateTimePicker1.Value = BirthDate;
            this.cbbPos.Text = pos;
            this.txtPhoneNumber.Text = phonenumber;
        }

        public fEditStaff(int ID, string name, DateTime BirthDate, string pos, string phonenumber, string username)
        {
            InitializeComponent();

            this.lbIdIncrease.Text = ID.ToString();
            this.txtName.Text = name;
            this.dateTimePicker1.Value = BirthDate;
            this.cbbPos.Text = pos;
            this.txtPhoneNumber.Text = phonenumber;
            this.txtUser.Text = username;

            this.txtUser.Enabled = false;
            this.txtPass.Enabled = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        string imgLocation = "";
        byte[] img = null;


        private void ptbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.png)(*.jpg)(*.jepg)(*.ico)|*.png;*.jpg;*.jepg;*.ico";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ptbImage.ImageLocation = imgLocation;
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void LoadImage()
        {
            imgLocation = "./images/blank-profile.png";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbIdIncrease.Text);
            string name = this.txtName.Text;
            DateTime birthdate = this.dateTimePicker1.Value;
            string pos = this.cbbPos.Text;
            string phonenumber = this.txtPhoneNumber.Text;

            if (imgLocation == "")
            {
                LoadImage();
            }

            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader bnr = new BinaryReader(stream);
            img = bnr.ReadBytes((int)stream.Length);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập Họ Tên", "Error");
                return;
            }
            if (string.IsNullOrEmpty(pos))
            {
                MessageBox.Show("Chọn Công việc", "Error");
                return;
            }
            if (string.IsNullOrEmpty(phonenumber))
            {
                MessageBox.Show("Nhập số điện thoại", "Error");
                return;
            }

            StaffDAL.Instance.EditStaff(id, name, img, birthdate, pos, phonenumber);
            StaffDAL.Instance.UpdateSalarybyPosition(id, pos);
            this.Close();
            
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
