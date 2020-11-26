using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class fBill : Form
    {

        private int Income;
        private int Spend;
        private string username;
        public fBill(string username)
        {
            InitializeComponent();
            this.username = username;
            loadBill();
        }

        #region Methods
        void sizeChange()
        {
            foreach (Control item in flowLayoutPanelBill.Controls)
            {
                item.Width = this.flowLayoutPanelBill.Width - 14;
            }
            int space = this.Width / 7;
            this.lbId.Location = new Point(30, 10);
            this.lbCheckout.Location = new Point(space, 10);
            this.lbIdStaff.Location = new Point(space * 2, 10);
            this.lbNameStaff.Location = new Point(space * 3, 10);
            this.lbNote.Location = new Point((int)(space * 4.8), 10);
            this.lbTotal.Location = new Point((int)(space * 6.2), 10);
        }
        public void loadBill()
        {
            flowLayoutPanelBill.Controls.Clear();
            List<Bill> bills = BillDAL.Instance.LoadBill();
            Income = Spend = 0;

            foreach (Bill bill in bills)
            {
                string StaffName = StaffDAL.Instance.GetNamebyID(bill.StaffID);
                ItemInBill item = new ItemInBill(bill.ID, bill.CheckOut, bill.StaffID, StaffName, bill.NOTE, bill.Total);
                if (bill.Total < 0)
                {
                    Spend += bill.Total;
                }
                else
                {
                    Income += bill.Total;
                }
                item.Tag = bill;
                flowLayoutPanelBill.Controls.Add(item);
            }
            lbTotalIncome.Text= string.Format("{0:n0}", Income).ToString();
            lbTotalSpend.Text= string.Format("{0:n0}", Spend).ToString();
            sizeChange();
        }
        #endregion

        #region Event
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            MakeABill frm = new MakeABill(username);
            frm.ShowDialog();
            loadBill();
        }

        private void flowLayoutPanelBill_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }
        #endregion
    }
}
