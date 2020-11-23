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
using MilkTeaShopManagement.DAL;
using MilkTeaHouseProject.DAL;
using System.Data.SqlClient;

namespace MilkTeaHouseProject
{
    public partial class fAddDrink : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string imgLocation = "";
        byte[] img = null;

        public fAddDrink()
        {
            InitializeComponent();
            LoadNameCategory();
            txtID.Text = (DrinkDAL.Instance.GetMaxDrinkID()+1).ToString();
        }

        #region Method
        private void LoadNameCategory()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Category");
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "NAME";
        }

        private void loadImage()
        {
            imgLocation = "./images/kawaii_coffee_64px.png";
        }
        #endregion

        #region Event
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

        private void pnImage_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgLocation == "")
                {
                    loadImage();
                }
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(stream);
                img = bnr.ReadBytes((int)stream.Length);
                if (cbCategory.Text == "")
                    MessageBox.Show("Vui lòng chọn loại");
                else if (txtNameDrink.Text == "")
                    MessageBox.Show("Vui lòng nhập tên món");
                else if (txtPrice.Text == "")
                    MessageBox.Show("Vui lòng nhập giá món");
                else
                {
                    DrinkDAL.Instance.AddDrink(txtNameDrink.Text, Int32.Parse(txtPrice.Text), cbCategory.Text, img);
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
