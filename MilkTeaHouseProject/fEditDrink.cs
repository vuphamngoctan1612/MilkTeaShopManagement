﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MilkTeaShopManagement.DAL;
using MilkTeaHouseProject.DAL;

namespace MilkTeaHouseProject
{
    public partial class fEditDrink : Form
    {
        public fEditDrink(int id, string name, int price, byte[] image)
        {
            InitializeComponent();
            LoadNameCategory();
            lbShowId.Text = id.ToString();
            txtNameDrink.Text = name;
            txtPrice.Text = price.ToString();
            if (image == null)
            {
                ptbImg.Image = null;
            }
            else
            {
                img = image;
                MemoryStream mstream = new MemoryStream(image);
                Bitmap bitmap = new Bitmap(mstream);
                ptbImg.Image = bitmap;
                ptbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        string imgLocation = "";
        byte[] img = null;
        private void ptbImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.png)(*.jpg)(*.jepg)(*.ico)|*.png;*.jpg;*.jepg;*.ico";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ptbImg.ImageLocation = imgLocation;
                ptbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void LoadNameCategory()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Category");
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "NAME";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (ptbImg.Image == null)
            {
                if (imgLocation == "")
                {
                    loadImage();
                }
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(stream);
                img = bnr.ReadBytes((int)stream.Length);
            }
            else
            {
                if (imgLocation != "")
                {
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader bnr = new BinaryReader(stream);
                    img = bnr.ReadBytes((int)stream.Length);
                }
            }
            if (txtNameDrink.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món");
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá");
            }
            else
            {
                DrinkDAL.Instance.EditDrink(Int32.Parse(lbShowId.Text), txtNameDrink.Text, Int32.Parse(txtPrice.Text),cbCategory.Text, img);
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }
        private void loadImage()
        {
            imgLocation = "./images/kawaii_coffee_64px.png";
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
