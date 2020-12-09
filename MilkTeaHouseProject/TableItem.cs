using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject.DTO
{
    public partial class TableItem : UserControl
    {
        public TableItem(int ID, string name, bool status)
        {
            InitializeComponent();
            lbName.Text = name;
            lbID.Text = ID.ToString();
        }

        private void TableItem_Load(object sender, EventArgs e)
        {

            this.btnChoose.Size = this.Size;
            this.lbName.Location = new Point((this.Width - lbName.Width)/2, lbName.Location.Y);
            this.lbName.ForeColor = Color.Black;
        }

        public void ChangeBackcolor()
        {
            
            this.BackColor = Color.FromArgb(0, 144, 218);
            this.PicTable2.BringToFront();
            this.lbName.ForeColor = Color.White;
        }

        public void ResetBackcolor()
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.picTable1.BringToFront();
            this.lbName.ForeColor = Color.Black;
        }

        public event EventHandler onChoose = null;
        public bool Selected = false;

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (onChoose != null)
            {
                onChoose.Invoke(this, new EventArgs());
            }
        }

        private void btnChoose_MouseHover(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(112, 195, 235);

            if (Selected == false)
                this.BackColor = color;
        }

        private void btnChoose_MouseLeave(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(255, 255, 255);

            if (Selected == false)
                this.BackColor = color;
        }

    }
}
