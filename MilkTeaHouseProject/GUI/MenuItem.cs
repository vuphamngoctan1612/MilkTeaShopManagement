﻿using System;
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

namespace MilkTeaHouseProject
{
    public partial class MenuItem : UserControl
    {
        public string ID { get => this.lbId.Text; set => this.lbId.Text = value; }
        public string NAME { get => this.lbName.Text; set => this.lbName.Text = value; }
        public byte[] Images { get; set; }
        public string COUNT { get => this.lbCount.Text; set => this.lbCount.Text = value; }

        public MenuItem(int id, string name, int price, string category, byte[] img, bool setcolor, int origin, int count)
        {
            InitializeComponent();

            this.lbId.Text = this.IDShow.Text = id.ToString();
            this.lbName.Text = this.NameShow.Text = name;
            this.lbName.BringToFront();
            this.lbPrice.Text = this.Price.Text = string.Format("{0:n0}", price).ToString();
            this.lbCategory.Text = this.Category.Text = category;
            this.lbOriginPrice.Text = this.oriPrice.Text = string.Format("{0:n0}", origin).ToString();
            this.lbCount.Text = this.Count.Text = count.ToString();

            if (img == null)
            {
                picFood.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(img);
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

        public event EventHandler onDel = null;
        public event EventHandler onEdit = null;

        #region Mothods
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

        void sizeChange()
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
            sizeChange();
        }
        #endregion

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel1.Visible == true)
            {
                Expand();
            }
            else
                Collapse();
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
            try
            {
                int count;
                int total;

                if (txtCount.Text == "")
                {
                    count = 0;
                }
                else
                {
                    count = int.Parse(this.txtCount.Text);
                }

                total = count * (ConvertToNumber(lbPrice.Text) - ConvertToNumber(lbOriginPrice.Text)) * (-1);
                DrinkDAL.Instance.SetCountbyID(int.Parse(ID), count);
                if (count != 0)
                    BillDAL.Instance.MakeBillforUpdateCountDrink(NAME, count, total);
                count += int.Parse(lbCount.Text);
                this.lbCount.Text = this.Count.Text = count.ToString();
                this.txtCount.Visible = false;
                this.btnAdd.Visible = false;
                this.txtCount.Text = "";
            }
            catch (SqlException)
            {
                this.errorShow.Visible = true;
                //this.errorShow.Location = new Point(txtCount.Location.X, txtCount.Location.Y + txtCount.Height);
                errorShow.Text = "Số lượng quá lớn";
            }
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
            this.errorShow.Visible = false;
        }
    }
}