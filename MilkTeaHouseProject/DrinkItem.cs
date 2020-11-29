using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace MilkTeaHouseProject
{
    public partial class DrinkItem : UserControl
    {
        public DrinkItem()
        {
            InitializeComponent();
        }
         
        public DrinkItem(string name, int price, byte[] image)
        {
            InitializeComponent();

            this.picFood.Width = this.Width - 2 * (this.picFood.Location.X);
            btnChoose.Size = this.Size;
            this.lbName.Text = name;
            this.lbPrice.Text = string.Format("{0:n0}", price).ToString();

            if (image == null)
            {
                picFood.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(image);
                Bitmap bitmap = new Bitmap(mstream);
                picFood.Image = bitmap;
                picFood.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public event EventHandler onChoose = null;

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (onChoose != null)
            {
                onChoose.Invoke(this, new EventArgs());
            }
        }

        private void btnChoose_MouseHover(object sender, EventArgs e)
        {
            this.btnChoose.OnHoverBaseColor1 = this.btnChoose.OnHoverBaseColor2 = Color.FromArgb(194, 228, 246);
            this.lbName.BackColor = Color.FromArgb(194, 228, 246);
            this.lbPrice.BackColor = Color.FromArgb(194, 228, 246);
        }

        private void btnChoose_MouseLeave(object sender, EventArgs e)
        {
            this.btnChoose.OnHoverBaseColor1 = this.btnChoose.OnHoverBaseColor2 = Color.Transparent;
            this.lbName.BackColor = Color.FromArgb(220, 244, 252);
            this.lbPrice.BackColor = Color.FromArgb(220, 244, 252);
        }

        private void DrinkItem_SizeChanged(object sender, EventArgs e)
        {
            this.picFood.Width = this.Width - 2 * (this.picFood.Location.X);
            this.picFood.Height = this.Height / 5 * 3;
            this.picFood.Location = new Point(this.picFood.Location.X, 5);
            this.lbName.Width = this.picFood.Width;
            this.lbName.Location = new Point(this.lbName.Location.X, this.picFood.Height + 10);
            this.lbPrice.Location = new Point(this.lbPrice.Location.X, this.picFood.Height + this.lbName.Height + 10);
            btnChoose.Size = this.Size;
        }
    }
}
