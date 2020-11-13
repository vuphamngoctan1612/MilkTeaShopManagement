using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;

namespace MilkTeaHouseProject
{
    public partial class BillItem : UserControl
    {
        public BillItem()
        {
            InitializeComponent();
        }

        public int Count 
        {
            get { return (int)this.count.Value; }
            set => this.count.Value = value; 
        }

        public string IdDrink
        {
            get { return this.lbDrinkID.Text; }
        }

        public BillItem (int idDrink, string foodName, int price, int count)
        {
            InitializeComponent();

            this.lbDrinkID.Text = idDrink.ToString();
            this.lbFoodName.Text = foodName;
            this.lbPrice.Text = price.ToString();
            this.count.Value = count;
            this.lbTotal.Text = (price * (int)this.count.Value).ToString();
        }

        public BillItem(string foodName, int price)
        {
            InitializeComponent();

            this.lbFoodName.Text = foodName;
            this.lbPrice.Text = price.ToString();
            this.lbTotal.Text = (price * (int)this.count.Value).ToString();
        }

        public event EventHandler onValueChanged = null;

        private void count_ValueChanged(object sender, EventArgs e)
        {
            this.lbTotal.Text = (int.Parse(this.lbPrice.Text) * (int)this.count.Value).ToString();

            BillInfoDAL.Instance.UpdateBillInfo(int.Parse(this.lbDrinkID.Text), (int)this.count.Value);

            if (onValueChanged != null)
            {
                onValueChanged.Invoke(this, new EventArgs());
            }
        }

        private void BillItem_Load(object sender, EventArgs e)
        {

        }
    }
}
