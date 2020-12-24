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
using MilkTeaShopManagement.DAL;

namespace MilkTeaHouseProject
{
    public partial class BillItem : UserControl
    {
        public BillItem()
        {
            InitializeComponent();

        }

        private int billID;
        public bool FLAG;
        public int COUNT;

        public int Count
        {
            get { return (int)this.count.Value; }
            set => this.count.Value = value;
        }

        public string IdDrink
        {
            get { return this.lbDrinkID.Text; }
        }

        public string PRICE
        {
            get { return this.lbPrice.Text; }
        }

        public long CovertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return long.Parse(tmp);
        }

        public BillItem(int idDrink, string foodName, long price, int count, int idBill)
        {
            InitializeComponent();

            this.lbDrinkID.Text = idDrink.ToString();
            this.lbFoodName.Text = foodName;
            this.lbPrice.Text = string.Format("{0:n0}", price).ToString();
            this.FLAG = true;
            this.count.Value = count;
            this.lbTotal.Text = string.Format("{0:n0}", price * (int)this.count.Value).ToString();
            this.billID = idBill;
            this.COUNT = count;

            this.count.Maximum = this.COUNT + DrinkDAL.Instance.GetCountbyDrinkID(idDrink);
        }

        public event EventHandler onValueChanged = null;
        public event EventHandler onDel = null;

        private void count_ValueChanged(object sender, EventArgs e)
        {
            if (FLAG == false)
            {
                if (count.Value > this.COUNT)
                {
                    if (DrinkDAL.Instance.GetCountbyDrinkID(int.Parse(lbDrinkID.Text)) > 0)
                    {
                        long price = CovertToNumber(this.lbPrice.Text);
                        long total = price * (int)this.count.Value;
                        this.lbTotal.Text = string.Format("{0:n0}", total).ToString();

                        BillInfoDAL.Instance.UpdateBillInfo(int.Parse(this.lbDrinkID.Text), this.billID, (int)this.count.Value);
                        BillDAL.Instance.UpdateBill(this.billID, price);
                        DrinkDAL.Instance.MinusCount(int.Parse(this.lbDrinkID.Text));
                        this.COUNT += 1;
                        this.count.Maximum -= 1;
                    }
                }
                else if (count.Value < this.COUNT)
                {
                    long price = CovertToNumber(this.lbPrice.Text);
                    long total = price * (int)this.count.Value;
                    this.lbTotal.Text = string.Format("{0:n0}", total).ToString();

                    BillInfoDAL.Instance.UpdateBillInfo(int.Parse(this.lbDrinkID.Text), this.billID, (int)this.count.Value);
                    BillDAL.Instance.UpdateMinusCountBill(this.billID, price);
                    DrinkDAL.Instance.SetCountbyID(int.Parse(this.lbDrinkID.Text), 1);
                    this.COUNT -= 1;
                    this.count.Maximum += 1;
                }

                if (onValueChanged != null)
                {
                    onValueChanged.Invoke(this, new EventArgs());
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (onDel != null)
            {
                onDel.Invoke(this, new EventArgs());
            }
        }

        public void FalseVisibleDel()
        {
            btnDel.Visible = false;
            count.Enabled = false;
        }
    }
}
