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
            this.lbPrice.Text = string.Format("{0:n0}", price).ToString();
            this.count.Value = count;
            this.lbTotal.Text = string.Format("{0:n0}", price * (int)this.count.Value).ToString();
        }

        public int CovertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return int.Parse(tmp);
        }

        public event EventHandler onValueChanged = null;
        public event EventHandler onDel = null;

        private void count_ValueChanged(object sender, EventArgs e)
        {
            int price = CovertToNumber(this.lbPrice.Text);
            int total = price * (int)this.count.Value;
            this.lbTotal.Text = string.Format("{0:n0}", total).ToString();

            BillInfoDAL.Instance.UpdateBillInfo(int.Parse(this.lbDrinkID.Text), (int)this.count.Value);

            if (onValueChanged != null)
            {
                onValueChanged.Invoke(this, new EventArgs());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (onDel != null)
            {
                onDel.Invoke(this, new EventArgs());
            }
        }
    }
}
