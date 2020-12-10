using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            List<Account> accounts = AccountDAL.Instance.GetListAccount();
            this.lbIDinrease.Text = (StaffDAL.Instance.GetMAXStaffID() + 1).ToString();
            foreach(Position pos in positions)
            {
                this.cbbPos.Items.Add(pos.Name);
            }    
            foreach(Account acc in accounts)
            {
                this.cbbUser.Items.Add(acc.Username);
            }    
            
        }
        public fAddStaff(int ID, string name, byte[] image, DateTime birthDate, string pos, string phonenumber, string username, string cmnd, bool sex, string address)
        {
            InitializeComponent();
            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            List<Account> accounts = AccountDAL.Instance.GetListAccount();
            this.lbIDinrease.Text = (StaffDAL.Instance.GetMAXStaffID() + 1).ToString();
            foreach (Position posistion in positions)
            {
                this.cbbPos.Items.Add(posistion.Name);
            }
            foreach (Account acc in accounts)
            {
                this.cbbUser.Items.Add(acc.Username);
            }
            this.lbIDinrease.Text = ID.ToString();
            this.txtName.Text = name;
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
            this.dptBirthDate.Value = birthDate;
            this.txtPhoneNumber.Text = phonenumber;
            this.cbbPos.Text = pos;
            this.cbbUser.Text = username;
            this.txtCMND.Text = cmnd;
            if (sex)
            {
                this.cbMan.Checked = true;
            }
            else
            {
                this.cbWoman.Checked = true;
            }
            this.txtAddress.Text = address;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string imgLocation = "";
        byte[] img = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = this.cbbUser.Text;
            string name = this.txtName.Text;
            DateTime birthdate = this.dptBirthDate.Value;
            string position = this.cbbPos.Text;
            string phoneNumber = this.txtPhoneNumber.Text;
            string cmnd = this.txtCMND.Text;
            string address = this.txtAddress.Text;
            bool sex = false;
            if (this.cbMan.Checked == true)
            {
                sex = true;
            }
            if (this.cbWoman.Checked == true)
            {
                sex = false;
            }
            if (this.cbMan.Checked == false && this.cbWoman.Checked == false)
            {
                MessageBox.Show("Chọn giới tính", "Error");
            }
            if (this.cbMan.Checked != false && this.cbWoman.Checked != false)
            {
                MessageBox.Show("Không chọn 2 giới tính", "Error");
            }
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
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Chọn Công việc", "Error");
                return;
            }
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Error");
                return;
            }
            if (cmnd.Length != 9)
            {
                MessageBox.Show("Số CMND không hợp lệ", "Error");
                return;
            }    
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập địa  chỉ", "Error");
            }    
            if (position == "Thu Ngân")
            {
                StaffDAL.Instance.AddStaff(name, img, birthdate, position, username,phoneNumber, cmnd, sex, address);
                this.Close();
            }  
            else
            {
                StaffDAL.Instance.AddStaff(name, img, birthdate, position, phoneNumber, cmnd, sex, address);
                this.Close();
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

        private void txtSalary_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cbbPos.Text != "Thu Ngân")
            {
                e.Handled = true;
            }
        }

        private void btAddUserName_Click(object sender, EventArgs e)
        {
            fSignUp frm = new fSignUp();
            frm.ShowDialog();
            List<Account> accounts = AccountDAL.Instance.GetListAccount();
            this.cbbUser.Items.Clear();
            foreach (Account acc in accounts)
            {
                this.cbbUser.Items.Add(acc.Username);
            }

        }

        private void cbbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbPos.Text == "Thu Ngân")
            {
                this.cbbUser.Visible = true;
                this.btAddUserName.Visible = true;
            }
            else
            {
                this.cbbUser.Visible = false;
                this.btAddUserName.Visible = false;
            }
        }

        private void btAddPosition_Click(object sender, EventArgs e)
        {
            fSetSalary frm = new fSetSalary();
            frm.ShowDialog();
            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            this.cbbPos.Items.Clear();
            foreach (Position pos in positions)
            {
                this.cbbPos.Items.Add(pos.Name);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbIDinrease.Text.ToString());
            string username = this.cbbUser.Text;
            string name = this.txtName.Text;
            DateTime birthdate = this.dptBirthDate.Value;
            string position = this.cbbPos.Text;
            string phoneNumber = this.txtPhoneNumber.Text;
            string cmnd = this.txtCMND.Text;
            string address = this.txtAddress.Text;
            bool sex = false;
            if (this.cbMan.Checked == true)
            {
                sex = true;
            }
            if (this.cbWoman.Checked == true)
            {
                sex = false;
            }
            if (this.cbMan.Checked == false && this.cbWoman.Checked == false)
            {
                MessageBox.Show("Chọn giới tính", "Error");
            }
            if (this.cbMan.Checked != false && this.cbWoman.Checked != false)
            {
                MessageBox.Show("Không chọn 2 giới tính", "Error");
            }
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
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Chọn Công việc", "Error");
                return;
            }
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Error");
                return;
            }
            if (cmnd.Length != 9)
            {
                MessageBox.Show("Số CMND không hợp lệ", "Error");
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nhập địa  chỉ", "Error");
            }
            if (position == "Thu Ngân")
            {
                StaffDAL.Instance.EditStaff(id, name, img, birthdate, position, username, phoneNumber, cmnd, sex, address);
                this.Close();
            }
            else
            {
                StaffDAL.Instance.EditStaff(id, name, img, birthdate, position, phoneNumber, cmnd, sex, address);
                this.Close();
            }
        }

        private void fAddStaff_Load(object sender, EventArgs e)
        {
            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);


        }
    }
}
