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

namespace MilkTeaHouseProject
{
    public partial class DrinkItem : UserControl
    {
        public DrinkItem()
        {
            InitializeComponent();
        }
         
        public DrinkItem(string name, int price)
        {
            InitializeComponent();

            btnChoose.Size =this.Size;
            this.lbName.Text = name;
            this.lbPrice.Text = price.ToString();
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
            this.btnChoose.OnHoverBaseColor1=this.btnChoose.OnHoverBaseColor2= Color.FromArgb(112, 195, 235);
            this.lbName.BackColor = Color.FromArgb(112, 195, 235);
            this.lbPrice.BackColor = Color.FromArgb(112, 195, 235);
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
        }
    }
}
