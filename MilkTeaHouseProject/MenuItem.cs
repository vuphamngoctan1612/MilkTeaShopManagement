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
        public MenuItem(int id, string name, int price,string nameCategory, byte[] img)
        {
            InitializeComponent();

            this.lbId.Text = id.ToString();
            this.lbName.Text = name;
            this.lbName.BringToFront();
            this.lbPrice.Text = price.ToString();
            this.lbCategory.Text = nameCategory;
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
        }
        public string ID { get => this.lbId.Text; set => this.lbId.Text = value; }
        public string NAME { get => this.lbName.Text; set => this.lbName.Text = value; }
        public byte[] Images { get; set; }

        public event EventHandler onDel = null;
        public event EventHandler onEdit = null;

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
            int space = this.Width / 6;
            lbId.Location = new Point(space, 20);
            lbName.Location = new Point(space * 3, 20);
            lbCategory.Location = new Point(space * 2, 20);
            lbPrice.Location = new Point(space * 4, 20);
            btnEdit.Location = new Point(space * 5-10, 20);
            btnDelete.Location = new Point(space * 5 +70 , 20);
        }
    }
}
