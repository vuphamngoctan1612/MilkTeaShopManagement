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

namespace MilkTeaHouseProject
{
    public partial class MenuItem : UserControl
    {
        public string ID { get => this.lbId.Text; set => this.lbId.Text = value; }
        public string NAME { get => this.lbName.Text; set => this.lbName.Text = value; }
        public byte[] Images { get; set; }

        public MenuItem(int id, string name, int price, string category, byte[] img, bool setcolor, int origin, int count)
        {
            InitializeComponent();

            this.lbId.Text = id.ToString();
            this.lbName.Text = name;
            this.lbName.BringToFront();
            this.lbPrice.Text = string.Format("{0:n0}", price).ToString();
            this.lbCategory.Text = category;
            this.lbOriginPrice.Text = origin.ToString();
            this.lbCount.Text = count.ToString();

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
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        public event EventHandler onDel = null;
        public event EventHandler onEdit = null;

        #region Mothods

        void sizeChange()
        {
            int space = this.Width / 6;
            lbId.Location = new Point((int)(space * 0.7), 10);
            lbCategory.Location = new Point((int)(space * 1.4), 10);
            lbName.Location = new Point(space * 2, 10);
            lbOriginPrice.Location = new Point(space* 3, 10);
            lbPrice.Location = new Point((int)(space * 3.8) , 10);
            lbCount.Location = new Point((int)(space * 4.5), 10);
            btnEdit.Location = new Point((int)(space * 5.2), 10);
            btnDelete.Location = new Point((int)(space * 5.2) + 65, 10);
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
    }
}