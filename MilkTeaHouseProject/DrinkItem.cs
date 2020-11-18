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
    }
}
