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
        public fAddDrink()
        {
            InitializeComponent();
            LoadNameCategory();
            txtID.Text = (DrinkDAL.Instance.GetMAXDrinkID() + 1).ToString();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        public void SeparateThousands(TextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                ulong valueBefore = ulong.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
                txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                txt.Select(txt.Text.Length, 0);
            }
        }

        public int ConvertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return int.Parse(tmp);
        }

        string imgLocation = "";
        byte[] img = null;
        #endregion

        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if (string.IsNullOrEmpty(cbCategory.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại");
                    return;
                }
                if (string.IsNullOrEmpty(txtNameDrink.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên món");
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá món");
                    return;
                }

                string name = this.txtNameDrink.Text;
                int price = ConvertToNumber(this.txtPrice.Text);
                string category = this.cbCategory.Text;

                DrinkDAL.Instance.AddDrink(name, price, category, img);
                MessageBox.Show("Cập nhật thành công");
                this.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Trùng ID.");
            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            SeparateThousands(this.txtPrice);
        }
        #endregion
    }
}
