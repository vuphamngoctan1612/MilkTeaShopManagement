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
        private string username;
        private string positonBefore;

        public fEditStaff(int ID, string name, DateTime BirthDate, string pos, string phonenumber)
        {
            InitializeComponent();
            this.lbIdIncrease.Text = ID.ToString();
            this.txtName.Text = name;
            this.dateTimePicker1.Value = BirthDate;
            this.cbbPos.Text = pos;
            this.txtPhoneNumber.Text = phonenumber;
        }

        public fEditStaff(int ID, string name, DateTime BirthDate, string pos, string phonenumber, string username, byte[] image)
        {
            InitializeComponent();

            this.lbIdIncrease.Text = ID.ToString();
            this.txtName.Text = name;
            this.dateTimePicker1.Value = BirthDate;
            this.cbbPos.Text = pos;
            this.txtPhoneNumber.Text = phonenumber;
            this.txtUser.Text = username;
            this.Username = username;

            this.PositonBefore = pos;

            if (pos == "Thu Ngân")
            {
                this.txtUser.Enabled = false;
                this.txtPass.Enabled = false;
            }

            if (image == null)
            {
                ptbImage.Image = null;
            }
            else
            {
                img = image;
                MemoryStream mstream = new MemoryStream(image);
                Bitmap bitmap = new Bitmap(mstream);
                ptbImage.Image = bitmap;
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int CheckPosition(string posBefore, string posAfter)
        {
            if (posBefore == "Thu Ngân")
            {
                if (posAfter == "Thu Ngân")
                {
                    return 0;   // đéo làm gì
                }
                else
                {
                    return 1;   // set username = null
                }
            }
            else
            {
                if (posAfter == "Thu Ngân")
                {
                    return 2;   // thêm acc
                }
                else
                {
                    return 0;   // đéo làm gì 
                }
            }
        }

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

        public string Username { get => username; set => username = value; }
        public string PositonBefore { get => positonBefore; set => positonBefore = value; }

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
            string positionAfter = this.cbbPos.Text;
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
            if (string.IsNullOrEmpty(positionAfter))
            {
                MessageBox.Show("Chọn Công việc", "Error");
                return;
            }            
            if (phonenumber.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Error");
                return;
            }
            if (this.CheckPosition(PositonBefore, positionAfter) == 0)
            {
                StaffDAL.Instance.EditStaff(id, name, img, birthdate, positionAfter, phonenumber);
                //StaffDAL.Instance.UpdateSalarybyPosition(id, positionAfter);
            }
            else if (this.CheckPosition(PositonBefore, positionAfter) == 1)
            {
                StaffDAL.Instance.SetUsernameToNULLbyID(id);
                AccountDAL.Instance.DelAccount(Username);
                StaffDAL.Instance.EditStaff(id, name, img, birthdate, positionAfter, phonenumber);
                //StaffDAL.Instance.UpdateSalarybyPosition(id, positionAfter);
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtUser.Text))
                {
                    MessageBox.Show("Nhập User", "Error");
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPass.Text))
                {
                    MessageBox.Show("Nhập PassWord", "Error");
                    return;
                }
                if (AccountDAL.Instance.SignUp(this.txtUser.Text, this.txtPass.Text))
                {
                    StaffDAL.Instance.EditStaff(id, name, img, birthdate, positionAfter, phonenumber, this.txtUser.Text);
                    //StaffDAL.Instance.UpdateSalarybyPosition(id, positionAfter);
                }
                else
                {
                    MessageBox.Show("Trùng username", "Error");
                    return;
                }
            }

            this.Close();
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbbPos.Text != "Thu Ngân")
            {
                e.Handled = true;
            }
        }

        private void cbbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            if (cbbPos.Text == "Thu Ngân")
            {
                this.txtUser.Text = this.Username;
            }
        }
    }
}
