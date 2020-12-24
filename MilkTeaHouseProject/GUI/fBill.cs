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

        private long Income;
        private long Spend;
        private string username;
        public fBill(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        #region Methods
        private void SizeChange()
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
        private void LoadBill()
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

                ItemInBill item = new ItemInBill(bill.ID, bill.CheckOut, bill.StaffID, StaffName, bill.NOTE, Math.Abs(bill.Total), setcolor);
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
            Spend *= -1;
            lbTotalIncome.Text= string.Format("{0:n0}", Income).ToString();
            lbTotalSpend.Text= string.Format("{0:n0}", Spend).ToString();
            SizeChange();
        }
        private void SetBackGround()
        {
            bool flag = false;
            foreach (Control control in this.flowLayoutPanelBill.Controls)
            {
                if (flag == false)
                {
                    control.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                    flag = true;
                }
                else
                {
                    control.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                    flag = false;
                }
            }
        }
        private void SearchStaffName(string name)
        {
            bool flag = false;
            foreach (Control item in this.flowLayoutPanelBill.Controls)
            {
                string StaffName = (item as ItemInBill).StaffName;
                if (cbSearch.Text == "Tất cả")
                {
                    if (!StaffName.ToLower().Contains(name.ToLower()))
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        item.Visible = true;
                        if (flag == false)
                        {
                            item.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                            flag = true;
                        }
                        else
                        {
                            item.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                            flag = false;
                        }
                    }
                }
                else if (cbSearch.Text == "Phiếu chi")
                {
                    int id = (item as ItemInBill).BillID;

                    Bill bill = BillDAL.Instance.GetBillByID(id);

                    if (bill.Total < 0)
                    {
                        if (!StaffName.ToLower().Contains(name.ToLower()))
                        {
                            item.Visible = false;
                        }
                        else
                        {
                            item.Visible = true;
                            if (flag == false)
                            {
                                item.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                                flag = true;
                            }
                            else
                            {
                                item.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                                flag = false;
                            }
                        }
                    }
                }
                else
                {
                    string note = (item as ItemInBill).NOTE;
                    if (!note.ToLower().Contains(cbSearch.Text.ToLower()))
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        if (!StaffName.ToLower().Contains(name.ToLower()))
                        {
                            item.Visible = false;
                        }
                        else
                        {
                            item.Visible = true;
                            if (flag == false)
                            {
                                item.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                                flag = true;
                            }
                            else
                            {
                                item.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                                flag = false;
                            }
                        }
                    }
                    
                }
            }
        }

        public void SearchAllNote()
        {
            bool flag = false;
            foreach (Control item in flowLayoutPanelBill.Controls)
            {
                item.Visible = true;
                if (flag == false)
                {
                    item.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                    flag = true;
                }
                else
                {
                    item.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                    flag = false;
                }
            }
        }

        private void SearchNotebyName(string name)
        {
            bool flag = false;
            foreach (Control item in flowLayoutPanelBill.Controls)
            {
                string note = (item as ItemInBill).NOTE;
                if (!note.ToLower().Contains(name.ToLower()))
                {
                    item.Visible = false;
                }
                else
                {
                    item.Visible = true;
                    if (flag == false)
                    {
                        item.BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                        flag = true;
                    }
                    else
                    {
                        item.BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                        flag = false;
                    }
                }
            }
        }

        private void SearchExpense()
        {
            List<Bill> bills = BillDAL.Instance.LoadBill();
            bool flag = false;

            SearchAllNote();
            for (int i = 0; i < bills.Count; i++)
            {
                if (bills[i].Total < 0)
                {
                    flowLayoutPanelBill.Controls[i].Visible = true;
                    if (flag == false)
                    {
                        flowLayoutPanelBill.Controls[i].BackColor = this.BackColor = Color.FromArgb(255, 255, 255);
                        flag = true;
                    }
                    else
                    {
                        flowLayoutPanelBill.Controls[i].BackColor = this.BackColor = Color.FromArgb(240, 240, 240);
                        flag = false;
                    }
                }
                else
                {
                    flowLayoutPanelBill.Controls[i].Visible = false;
                }
            }
        }

        #endregion

        #region Event
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            MakeABill frm = new MakeABill(username);
            frm.onAdd += Frm_onAdd;

            frm.ShowDialog();
        }

        private void Frm_onAdd(object sender, EventArgs e)
        {
            Bill bill = BillDAL.Instance.GetBillByID(BillDAL.Instance.GetMAXIDBill());
            ItemInBill item = new ItemInBill(bill.ID, bill.CheckOut, bill.StaffID, StaffDAL.Instance.GetNamebyID(bill.StaffID), bill.NOTE, Math.Abs(bill.Total), true);

            this.flowLayoutPanelBill.Controls.Add(item);
            this.SetBackGround();
            this.SizeChange();
            this.cbSearch.SelectedIndex = 0;
            this.SearchAllNote();
        }

        private void flowLayoutPanelBill_SizeChanged(object sender, EventArgs e)
        {
            SizeChange();
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
            LoadBill();

            cbSearch.SelectedIndex = 0;
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flowLayoutPanelBill.Controls.Count > 0)
            {
                if (flowLayoutPanelBill.Controls.Count != BillDAL.Instance.CountBillStatusTrue())
                {
                    LoadBill();
                }
            }
        }

        #endregion

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cbSearch.SelectedIndex == 0)
            {
                SearchAllNote();
            } 
            if (cbSearch.SelectedIndex == 1)
            {
                SearchNotebyName("Nhập");
            }
            if (cbSearch.SelectedIndex == 2)
            {
                SearchNotebyName("Bán hàng");
            }
            if (cbSearch.SelectedIndex == 3)
            {
                SearchNotebyName("Kết toán lương");
            }
            if (cbSearch.SelectedIndex == 4)
            {
                SearchExpense();
            }
        }
    }
}
