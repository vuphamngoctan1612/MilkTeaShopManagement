using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;

namespace MilkTeaHouseProject
{
    public partial class fStaff : Form
    {
        private int totalSalary;
        private string username;
        public fStaff(string username)
        {
            InitializeComponent();
            LoadStaff();
            this.username = username;
        }
        #region Method

        void sizeChange()
        {
            foreach (Control item in flowLayoutPanelStaff.Controls)
            {
                item.Width = this.flowLayoutPanelStaff.Width;
            }
            int space = this.flowLayoutPanelStaff.Width / 8;
            lbID.Location = new Point(85, 10);
            lbName.Location = new Point((int)(space * 1.7), 10);
            lbPosition.Location = new Point((int)(space * 3.2), 10);
            lbUserName.Location = new Point((int)(space * 4.2), 10);
            lbOvertime.Location = new Point((int)(space * 5.4), 10);
            lbFaust.Location = new Point((int)(space * 6.5), 10);
            lbSalary.Location = new Point((int)(space * 7.2), 10);
        }
        public void LoadStaff()
        {
            totalSalary = 0;
            List<Staff> staffs = StaffDAL.Instance.GetListStaff();

            List<Position> positions = PositionDAL.Instance.GetListPosistion();

            bool setcolor = true;

            foreach (Staff staff in staffs)
            {
                if (setcolor == true)
                    setcolor = false;
                else
                    setcolor = true;
                int salaryReceived = 0;
                foreach (Position pos in positions)
                {
                    if (pos.Name == staff.Position)
                    {
                        salaryReceived = pos.Salary + staff.OverTime * pos.OverTimeSalary - staff.Fault * pos.MinusSalary;
                    }
                }

                StaffDAL.Instance.UpdateSalaryReceived(staff.ID, salaryReceived);
                StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image, staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Fault, salaryReceived, staff.Sex, staff.CMND, staff.PhoneNumber, staff.Address, setcolor);
                totalSalary += salaryReceived;
                staffItem.onEdit += Item_OnEdit;
                staffItem.onDel += StaffItem_onDel;
                staffItem.onOverTimeValueChanged += StaffItem_onOverTimeValueChanged;
                staffItem.onFaultChanged += StaffItem_onFaultChanged;
                staffItem.Tag = staff;

                flowLayoutPanelStaff.Controls.Add(staffItem);
                sizeChange();
            }
        }

        public void SearchStaff(string search)
        {
            totalSalary = 0;
            List<Staff> staffs = StaffDAL.Instance.GetListStaff();

            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            this.flowLayoutPanelStaff.Controls.Clear();
            bool setcolor = true;

            foreach (Staff staff in staffs)
            {
                foreach (Position pos in positions)
                {
                    string name = staff.Name;
                    if (setcolor == true)
                        setcolor = false;
                    else
                        setcolor = true;
                    if (name.ToLower().Contains(this.txtSearch.Text.ToLower()))
                    {
                        if (staff.Position == pos.Name)
                        {
                            int salaryReceived = pos.Salary + staff.OverTime * pos.OverTimeSalary - staff.Fault * pos.MinusSalary;
                            StaffDAL.Instance.UpdateSalaryReceived(staff.ID, salaryReceived);
                            StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image, staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Fault, salaryReceived, staff.Sex, staff.CMND, staff.PhoneNumber, staff.Address, setcolor);

                            totalSalary += staff.SalaryReceived;
                            staffItem.onEdit += Item_OnEdit;
                            staffItem.onDel += StaffItem_onDel;
                            staffItem.onOverTimeValueChanged += StaffItem_onOverTimeValueChanged;
                            staffItem.onFaultChanged += StaffItem_onFaultChanged;
                            staffItem.Tag = staff;

                            flowLayoutPanelStaff.Controls.Add(staffItem);
                        }
                    }
                    sizeChange();
                }
            }
        }
        #endregion

        #region Events
        private void StaffItem_onFaultChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void StaffItem_onOverTimeValueChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void StaffItem_onDel(object sender, EventArgs e)
        {
            int iD = ((sender as StaffItem).Tag as Staff).ID;
            string username = ((sender as StaffItem).Tag as Staff).UserName;
            string pos = ((sender as StaffItem).Tag as Staff).Position;
            if (pos == "Thu Ngân")
            {
                BillDAL.Instance.UpDateStaffIDtoNULL(iD);
                StaffDAL.Instance.DelStaff(iD);
                AccountDAL.Instance.DelAccount(username);
            }
            else if (pos == "Quản lí")
            {
                MessageBox.Show("Không thể xóa chức vụ này");
            }
            else
            {
                BillDAL.Instance.UpDateStaffIDtoNULL(iD);
                StaffDAL.Instance.DelStaff(iD);
            }

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }
        private void Item_OnEdit(object sender, EventArgs args)
        {
            
            int id = ((sender as StaffItem).Tag as Staff).ID;
            string name = ((sender as StaffItem).Tag as Staff).Name;
            DateTime birthDate = ((sender as StaffItem).Tag as Staff).BirthDate;
            string pos = ((sender as StaffItem).Tag as Staff).Position;
            string phonenumber = ((sender as StaffItem).Tag as Staff).PhoneNumber;
            string username = ((sender as StaffItem).Tag as Staff).UserName;
            byte[] image = ((sender as StaffItem).Tag as Staff).Image;
            string address = ((sender as StaffItem).Tag as Staff).Address;
            bool sex = ((sender as StaffItem).Tag as Staff).Sex;
            string cmnd = ((sender as StaffItem).Tag as Staff).CMND;
            string phoneNumber = ((sender as StaffItem).Tag as Staff).PhoneNumber;
            fAddStaff frm = new fAddStaff( id,  name,  image,  birthDate,  pos,  phonenumber,  username,  cmnd,  sex,  address);
            frm.btEdit.Visible = true;
            frm.lbNameForm.Text = "Sửa thông tin nhân viên";
            frm.ShowDialog();

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.btnAdd.Visible = true;
            f.ShowDialog();

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }

        private void flowLayoutPanelStaff_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }

        private void btSetSalary_Click(object sender, EventArgs e)
        {
            fSetSalary f = new fSetSalary();
            f.ShowDialog();

            this.flowLayoutPanelStaff.Controls.Clear();
            LoadStaff();
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelStaff.Controls.Count > 0)
            {
                StaffDAL.Instance.ResetOverandFault();
                BillDAL.Instance.UpdateBillSalary(username, totalSalary * -1);
                MessageBox.Show("Kết toán lương thành công");
                this.flowLayoutPanelStaff.Controls.Clear();
                LoadStaff();
            }
            else
            {
                MessageBox.Show("Không có nhân viên nào");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStaff(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchStaff(txtSearch.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
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

                    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ID as N'Mã nhân viên', Name as N'Tên', BIRTHDATE as N'Ngày sinh', POSITION as N'Vị trí', USERNAME as N'Tên đăng nhập', OVERTIME as N'Giờ tăng ca', SalaryReceived as N'Lương nhận được', Fault as N'Lỗi', PhoneNumber as N'Số điện thoại', CMND as N'Chứng minh nhân dân', Sex as N'Giới tính', Address as N'Địa chỉ' FROM Staff");

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
                            if (data.Rows[i][j].ToString() == "True")
                            {
                                worksheet.Cells[i + 2, j + 1] = "Nam";
                            }
                            else if (data.Rows[i][j].ToString() == "False")
                            {
                                worksheet.Cells[i + 2, j + 1] = "Nữ";
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = data.Rows[i][j].ToString();
                            }
                        }
                    }
                    workbook.SaveAs(sfd.FileName);
                }
            }
        }
        #endregion
    }
}
