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
        public int ID { get => int.Parse(this.txtID.Text); }
        public string DrinkName { get => this.txtNameDrink.Text; }
        public long Price { get => ConvertToNumber(this.txtPrice.Text); }
        public string Category
        {
            get
            {
                if (this.txtCategory.Visible == true)
                {
                    return this.txtCategory.Text;
                }
                else
                {
                    return this.cbbCategory.Text;
                }
            }
        }
        public byte[] Image { get => this.img; }
        public System.Drawing.Image IMAGE { get => this.ptbImage.Image; set => this.ptbImage.Image = value; }
        public long Origin { get => ConvertToNumber(this.txtOriginPrice.Text); }

        public fAddDrink()
        {
            InitializeComponent();
            LoadNameCategory();

            txtID.Text = (DrinkDAL.Instance.GetMAXDrinkID() + 1).ToString();
            btnAdd.Visible = true;
            btnEdit.Visible = false;
            btnAdd.BringToFront();
            lbNameForm.Text = "Thêm món";
            txtID.Enabled = false;
        }

        public fAddDrink(int id, string name, long price, byte[] image, long origin, int count)
        {
            InitializeComponent();
            LoadNameCategory();

            txtID.Text = id.ToString();
            txtID.Enabled = false;
            txtNameDrink.Text = name;
            txtPrice.Text = price.ToString();
            cbbCategory.Text = DrinkDAL.Instance.GetCategorybyID(id);
            txtOriginPrice.Text = origin.ToString();

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

            btnEdit.Visible = true;
            btnAdd.Visible = false;
            btnEdit.BringToFront();
            lbNameForm.Text = "Sửa món";
        }

        public fAddDrink(int id, string name, string category, int price, byte[] image, int origin, int count)
        {
            InitializeComponent();
            LoadNameCategory();

            txtID.Text = id.ToString();
            txtID.Enabled = false;
            txtNameDrink.Text = name;
            cbbCategory.Text = DrinkDAL.Instance.GetCategorybyID(id);
            txtPrice.Text = price.ToString();
            txtOriginPrice.Text = origin.ToString();

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

            btnEdit.Visible = true;
            btnAdd.Visible = false;
            btnEdit.BringToFront();
            lbNameForm.Text = "Sửa món";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Method
        private void LoadNameCategory()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Category");
            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "NAME";
        }

        private void loadImage()
        {
            imgLocation = "./images/kawaii_coffee_64px.png";
        }

        public void SeparateThousands(Guna.UI.WinForms.GunaLineTextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                ulong valueBefore = ulong.Parse(ConvertToNumber(txt.Text).ToString(), System.Globalization.NumberStyles.AllowThousands);
                txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                txt.Select(txt.Text.Length, 0);
            }
        }

        public long ConvertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return long.Parse(tmp);
        }

        private void ShowError(Control control, string error)
        {
            control.Focus();
            errorShow.Visible = true;
            errorShow.Location = new Point(control.Location.X, control.Location.Y + control.Height);
            errorShow.Text = error;
        }
        #endregion

        string imgLocation = "";
        byte[] img = null;
        public event EventHandler onEdit = null;
        public event EventHandler onAdd = null;

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
            dialog.Filter = "png files(.png)|.png|jpg files(.jpg)|.jpg| All files(.png)(.jpg)(.jepg)(.ico)|*.png;*.jpg;*.jepg;*.ico";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ptbImage.ImageLocation = imgLocation;
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string category = "";
            try
            {
                if (imgLocation == "")
                {
                    loadImage();
                }
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(stream);
                img = bnr.ReadBytes((int)stream.Length);

                if (txtCategory.Visible == true)
                {
                    try
                    {
                        if (string.IsNullOrEmpty(this.txtCategory.Text))
                        {
                            ShowError(txtCategory, "Vui lòng nhập loại mới");
                            return;
                        }

                        category = this.txtCategory.Text;
                        CategoryDAL.Instance.AddCategory(category);
                    }
                    catch (SqlException)
                    {
                        ShowError(txtCategory, "Trùng loại");
                    }
                }
                else
                {
                    category = cbbCategory.Text;
                }

                if (string.IsNullOrEmpty(txtNameDrink.Text))
                {
                    ShowError(txtNameDrink, "Vui lòng nhập tên món");
                    return;
                }
                if (string.IsNullOrEmpty(txtOriginPrice.Text))
                {
                    ShowError(txtOriginPrice, "Vui lòng nhập giá gốc món");
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    ShowError(txtPrice, "Vui lòng nhập giá");
                    return;
                }

                string name = this.txtNameDrink.Text;
                long price = ConvertToNumber(this.txtPrice.Text);
                long originPrice = ConvertToNumber(txtOriginPrice.Text);

                DrinkDAL.Instance.AddDrink(name, price, category, img, originPrice);
                this.Close();

                if (onAdd != null)
                {
                    onAdd.Invoke(this, new EventArgs());
                }
            }
            catch (SqlException)
            {
                ShowError(txtID, "");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string category = "";
            if (ptbImage.Image == null)
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

            if (txtCategory.Visible == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(this.txtCategory.Text))
                    {
                        ShowError(txtCategory, "Vui lòng nhập loại mới");
                        return;
                    }

                    category = txtCategory.Text;
                    CategoryDAL.Instance.AddCategory(category);
                }
                catch (SqlException)
                {
                    ShowError(txtCategory, "Trùng loại");
                }
            }
            else
            {
                category = cbbCategory.Text;
            }

            if (string.IsNullOrEmpty(txtNameDrink.Text))
            {
                ShowError(txtNameDrink, "Vui lòng nhập tên món");
            }
            if (string.IsNullOrEmpty(txtOriginPrice.Text))
            {
                ShowError(txtOriginPrice, "Vui lòng nhập giá gốc món");
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                ShowError(txtPrice, "Vui lòng nhập giá");
            }

            int id = int.Parse(this.txtID.Text);
            string name = this.txtNameDrink.Text;
            long price = ConvertToNumber(this.txtPrice.Text);
            long OriginPrice = ConvertToNumber(this.txtOriginPrice.Text);

            DrinkDAL.Instance.EditDrink(id, name, price, category, img, OriginPrice);
            this.Close();

            if (onEdit != null)
            {
                onEdit.Invoke(this, new EventArgs());
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter && this.lbNameForm.Text == "Thêm món")
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.lbNameForm.Text == "Sửa món")
            {
                this.btnEdit_Click(sender, e);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            SeparateThousands(this.txtPrice);

            errorShow.Visible = false;
        }

        private void txtOriginPrice_TextChanged(object sender, EventArgs e)
        {
            SeparateThousands(this.txtOriginPrice);

            errorShow.Visible = false;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Visible == true)
            {
                txtCategory.Visible = false;
            }
            else
            {
                txtCategory.Visible = true;
                txtCategory.BringToFront();
                txtCategory.Focus();
            }

        }

        private void fAddDrink_Load(object sender, EventArgs e)
        {
            DropShadow shadow = new DropShadow();
            shadow.ApplyShadows(this);
        }

        private void txtNameDrink_TextChanged(object sender, EventArgs e)
        {
            errorShow.Visible = false;
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            this.errorShow.Visible = false;
        }

        private void txtNameDrink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && this.lbNameForm.Text == "Thêm món")
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.lbNameForm.Text == "Sửa món")
            {
                this.btnEdit_Click(sender, e);
            }
        }
        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && this.lbNameForm.Text == "Thêm món")
            {
                this.btnAdd_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Enter && this.lbNameForm.Text == "Sửa món")
            {
                this.btnEdit_Click(sender, e);
            }
        }
        #endregion

    }
}