using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        public string Name { get => this.lbName.Text; set => this.lbName.Text = value; }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }

    }
}
