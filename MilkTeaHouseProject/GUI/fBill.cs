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
using MilkTeaShopManagement.DAL;

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
        }

        #region Methods
        void sizeChange()
        {
            foreach (Control item in flowLayoutPanelBill.Controls)
            {
                item.Width = this.flowLayoutPanelBill.Width;
            }
            int space = this.Width / 7;
            this.lbId.Location = new Point(30, 5);
            this.lbCheckout.Location = new Point(space, 5);
            this.lbIdStaff.Location = new Point(space * 2, 5);
            this.lbNameStaff.Location = new Point(space * 3, 5);
            this.lbNote.Location = new Point((int)(space * 4.3), 5);
            this.lbTotal.Location = new Point((int)(space * 6.2), 5);
        }
        public void loadBill()
        {
            flowLayoutPanelBill.Controls.Clear();
            List<Bill> bills = BillDAL.Instance.LoadBill();
            Income = Spend = 0;
            bool setcolor = true;

            foreach (Bill bill in bills)
            {
                if (setcolor)
                    setcolor = false;
                else
                    setcolor = true;

                string StaffName = StaffDAL.Instance.GetNamebyID(bill.StaffID);

                ItemInBill item = new ItemInBill(bill.ID, bill.CheckOut, bill.StaffID, StaffName, bill.NOTE, bill.Total, setcolor);
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

        private void SearchStaffName(string name)
        {
            flowLayoutPanelBill.Controls.Clear();
            List<Bill> bills = BillDAL.Instance.LoadBill();
            Income = Spend = 0;
            bool setcolor = true;

            foreach (Bill bill in bills)
            {
                string StaffName = StaffDAL.Instance.GetNamebyID(bill.StaffID);

                if (StaffName.ToLower().Contains(name.ToLower()))
                {
                    if (setcolor)
                        setcolor = false;
                    else
                        setcolor = true;


                    ItemInBill item = new ItemInBill(bill.ID, bill.CheckOut, bill.StaffID, StaffName, bill.NOTE, bill.Total, setcolor);
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
                lbTotalIncome.Text = string.Format("{0:n0}", Income).ToString();
                lbTotalSpend.Text = string.Format("{0:n0}", Spend).ToString();
            }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchStaffName(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStaffName(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            loadBill();
        }
        #endregion

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    object misValue = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                    application.Visible = false;
                    Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Bill.ID as N'Mã hóa đơn', CHECKOUT as N'Thời gian', STAFFID as N'Mã nhân viên', NAME as N'Tên nhân viên', NOTE as 'Ghi chú', Total as N'Tổng hóa đơn' FROM Bill JOIN Staff ON Bill.STAFFID = Staff.ID; ");
                    worksheet = application.Worksheets.Add(misValue, misValue, misValue, misValue);
                    worksheet.Name = "Staff";
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = data.Columns[i].ColumnName;
                    }
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < data.Columns.Count; j++)
                        {
                                worksheet.Cells[i + 2, j + 1] = data.Rows[i][j].ToString();
                        }
                    }
                    workbook.SaveAs(sfd.FileName);
                }
            }
        }
    }
}
