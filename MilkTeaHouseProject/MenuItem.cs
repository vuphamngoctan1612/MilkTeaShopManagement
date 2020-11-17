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

namespace MilkTeaHouseProject
{
    public partial class MenuItem : UserControl
    {
        public MenuItem(string id, string name, int price, byte[] img)
        {
            InitializeComponent();

            this.lbId.Text = id;
            this.lbName.Text = name;
            this.lbName.BringToFront();
            this.lbPrice.Text = price.ToString();
            if (img == null)
            {
                picFood.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(img);
                Bitmap bitmap = new Bitmap(mstream);
                picFood.Image = bitmap;
                picFood.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public string ID { get => this.lbId.Text; set => this.lbId.Text = value; }
        public string Name { get => this.lbName.Text; set => this.lbName.Text = value; }
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

        private void lbId_Click(object sender, EventArgs e)
        {

        }
    }
}
