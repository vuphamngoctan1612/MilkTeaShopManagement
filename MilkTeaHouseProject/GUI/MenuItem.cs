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
using MilkTeaShopManagement.DAL;
using MilkTeaHouseProject.DAL;
using System.Data.SqlClient;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class MenuItem : UserControl
    {
        public string ID
        {
            get => this.lbId.Text;
            set
            {
                this.lbId.Text = this.IDShow.Text = value;
            }
        }
        public string NAME
        {
            get => this.lbName.Text;
            set => this.lbName.Text = this.NameShow.Text = value;
        }
        public string CATEGORY
        {
            get => this.lbCategory.Text;
            set => lbCategory.Text = this.Category.Text = value;
        }
        public byte[] IMAGE { get => this.img; set => this.img = value; }
        public Image Image { set => this.picFood.Image = this.gunaPictureBox1.Image = value; }
        public string COUNT
        {
            get => this.lbCount.Text;
            set => this.lbCount.Text = this.Count.Text = string.Format("{0:n0}", value).ToString();
        }
        public long PRICE
        {
            get => ConvertToNumber(this.Price.Text);
            set => this.lbPrice.Text = this.Price.Text = string.Format("{0:n0}", value).ToString();
        }
        public long ORIGIN
        {
            get => ConvertToNumber(this.lbOriginPrice.Text);
            set => this.lbOriginPrice.Text = this.oriPrice.Text = string.Format("{0:n0}", value).ToString();
        }

        public Guna.UI.WinForms.GunaLineTextBox TxtCount { get => this.txtCount; set => this.txtCount = value; }
        public Guna.UI.WinForms.GunaButton BtnAdd { get => this.btnAdd; set => this.btnAdd = value; }
        public Guna.UI.WinForms.GunaButton BtnShowAddCount { get => this.btnShowAddCount; set => this.btnShowAddCount = value; }
        public string UserName { get; set; }

        public MenuItem(int id, string name, long price, string category, byte[] image, bool setcolor, long origin, int count, string username)
        {
            InitializeComponent();
            this.UserName = username;

            this.lbId.Text = this.IDShow.Text = id.ToString();
            this.lbName.Text = this.NameShow.Text = name;
            this.lbName.BringToFront();
            this.lbPrice.Text = this.Price.Text = string.Format("{0:n0}", price).ToString();
            this.lbCategory.Text = this.Category.Text = category;
            this.lbOriginPrice.Text = this.oriPrice.Text = string.Format("{0:n0}", origin).ToString();
            this.lbCount.Text = this.Count.Text = string.Format("{0:n0}", count).ToString();

            if (image == null)
            {
                picFood.Image = null;
            }
            else
            {
                img = image;
                MemoryStream mstream = new MemoryStream(image);
                picFood.Image = Image.FromStream(mstream);
                picFood.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (setcolor == true)
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
                this.txtCount.BackColor = this.btnAdd.BaseColor = this.btnShowAddCount.BaseColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
                this.txtCount.BackColor = this.btnAdd.BaseColor = this.btnShowAddCount.BaseColor = Color.FromArgb(255, 255, 255);
            }
            this.gunaPictureBox1.Image = this.picFood.Image;
        }

        #region Methods
        public void UpdateItem(int id)
        {
            Drink drink = DrinkDAL.Instance.GetDrinkByID(id);

            this.lbId.Text = this.IDShow.Text = drink.ID.ToString();
            this.lbName.Text = this.NameShow.Text = drink.Name;
            this.lbCategory.Text = this.Category.Text = drink.Category;
            //this.picFood.Image = this.gunaPictureBox1.Image = drink.Image;
            this.IMAGE = drink.Image;
            this.lbPrice.Text = this.Price.Text = string.Format("{0:n0}", drink.Price).ToString();
            this.lbOriginPrice.Text = this.oriPrice.Text = string.Format("{0:n0}", drink.OriginPrice).ToString();
            this.lbCount.Text = this.Count.Text = drink.Count.ToString();
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

        public int ConvertTo_IntNumber(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return int.Parse(tmp);
        }

        public void SeparateThousands(Guna.UI.WinForms.GunaLineTextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                ulong valueBefore = ulong.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
                txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                txt.Select(txt.Text.Length, 0);
            }
        }

        void SizeChange()
        {
            int space = this.Width / 6;
            lbId.Location = new Point((int)(space), 15);
            lbCategory.Location = new Point((int)(space * 2), 15);
            lbName.Location = new Point(space * 3, 15);
            lbOriginPrice.Location = new Point(space * 4, 15);
            lbPrice.Location = new Point((int)(space * 4.8), 15);
            lbCount.Location = new Point((int)(space * 5.5), 15);
        }
        #endregion

        public event EventHandler onDel = null;
        public event EventHandler onEdit = null;
        private byte[] img = null;

        #region Event
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (onEdit != null)
            {
                onEdit.Invoke(this, new EventArgs());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (onDel != null)
            {
                onDel.Invoke(this, new EventArgs());
            }
        }

        private void MenuItem_SizeChanged(object sender, EventArgs e)
        {
            SizeChange();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel1.Visible == true)
            {
                Expand();
            }
            else
            {
                Collapse();
            }
        }

        public void Expand()
        {
            this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.Height = this.panel2.Height = 350;
        }

        public void Collapse()
        {
            this.panel1.Visible = true;
            this.panel2.Visible = false;
            this.Height = this.panel1.Height = 70;
        }

        private void MenuItem_Load(object sender, EventArgs e)
        {
            Collapse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                int count = ConvertTo_IntNumber(this.txtCount.Text);
                long total;

                if (txtCount.Text == "")
                {
                    count = 0;
                }
                else
                {
                    count = ConvertTo_IntNumber(this.txtCount.Text);
                }

                total = count * ConvertToNumber(lbOriginPrice.Text) * (-1);
                DrinkDAL.Instance.SetCountbyID(int.Parse(ID), count);
                if (count != 0)
                {
                    BillDAL.Instance.MakeBillforUpdateCountDrink(NAME, count, total, UserName);
                }
                count += ConvertTo_IntNumber(lbCount.Text);
                this.lbCount.Text = this.Count.Text = string.Format("{0:n0}", count).ToString();
                this.txtCount.Visible = false;
                this.btnAdd.Visible = false;
                this.txtCount.Text = "";
        }

        private void btnShowAddCount_Click(object sender, EventArgs e)
        {
            this.txtCount.Visible = true;
            this.btnAdd.Visible = true;
            this.txtCount.Focus();
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.btnAdd_Click(sender, e);
            }
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            this.SeparateThousands(this.txtCount);
            this.errorShow.Visible = false;
        }
        #endregion
    }
}