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
        List<StaffItem> staffItems = new List<StaffItem>();
        public fStaff(string username)
        {
            InitializeComponent();
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
                StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image, staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Fault, staff.SalaryReceived, staff.Sex, staff.CMND, staff.PhoneNumber, staff.Address, setcolor);

                totalSalary += staff.SalaryReceived;
                staffItem.onEdit += Item_OnEdit;
                staffItem.onDel += StaffItem_onDel;
                staffItem.onOverTimeValueChanged += StaffItem_onOverTimeValueChanged;
                staffItem.onFaultChanged += StaffItem_onFaultChanged;
                staffItem.Tag = staff;

                flowLayoutPanelStaff.Controls.Add(staffItem);
                staffItems.Add(staffItem);
            }

            sizeChange();
        }

        public void SearchStaff(string search)
        {
            bool flag = false;
            foreach (Control item in this.flowLayoutPanelStaff.Controls)
            {
                string StaffName = (item as StaffItem).NAME;

                if (!StaffName.ToLower().Contains(search.ToLower()))
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
        private void SetBackGround()
        {
            bool flag = false;
            foreach (Control control in this.flowLayoutPanelStaff.Controls)
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
        #endregion

        #region Events
        private void StaffItem_onFaultChanged(object sender, EventArgs e) { }
        private void StaffItem_onOverTimeValueChanged(object sender, EventArgs e) { }
        private void StaffItem_onDel(object sender, EventArgs e)
        {
            int iD = ((sender as StaffItem).Tag as Staff).ID;
            string username = ((sender as StaffItem).Tag as Staff).UserName;
            string pos = ((sender as StaffItem).Tag as Staff).Position;
            if (pos == "Thu Ngân")
            {
                BillDAL.Instance.UpDateStaffIDtoNULL(iD);
                StaffDAL.Instance.SetUsernameToNULLbyID(iD);
                AccountDAL.Instance.DelAccount(username);
                StaffDAL.Instance.DelStaff(iD);
            }
            else if (pos.ToUpper() == "QUẢN LÝ")
            {
                MessageBox.Show("Không thể xóa chức vụ này");
            }
            else
            {
                BillDAL.Instance.UpDateStaffIDtoNULL(iD);
                StaffDAL.Instance.DelStaff(iD);
            }
            this.flowLayoutPanelStaff.Controls.Remove(sender as StaffItem);
            this.SetBackGround();
        }
        private void Item_OnEdit(object sender, EventArgs args)
        {

            int id = ((sender as StaffItem).Tag as Staff).ID;
            Staff staff = StaffDAL.Instance.GetStaffById(id);
            string name = staff.Name;
            DateTime birthDate = staff.BirthDate;
            string pos = staff.Position;
            string phonenumber = staff.PhoneNumber;
            string username = staff.UserName;
            byte[] image = staff.Image;
            string address = staff.Address;
            bool sex = staff.Sex;
            string cmnd = staff.CMND;
            string phoneNumber = staff.PhoneNumber;
            fAddStaff frm = new fAddStaff(id, name, image, birthDate, pos, phonenumber, username, cmnd, sex, address);
            frm.ActivebtnEdit();
            frm.UpdatelbNameForm("Sửa thông tin nhân viên");
            frm.ShowDialog();
            (sender as StaffItem).UpdateStaffItem(id);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.ActivebtnAdd();
            f.ShowDialog();
            List<Staff> staffs = StaffDAL.Instance.GetListStaff();
            bool setcolor = true;
            if (this.flowLayoutPanelStaff.Controls.Count < staffs.Count)
            {
                foreach (Staff staff in staffs)
                {
                    int count = staffs.IndexOf(staff);
                    if (staffs.IndexOf(staff) + 1 == staffs.Count)
                    {
                        StaffItem staffItem = new StaffItem(staff.ID, staff.Name, staff.Image, staff.BirthDate, staff.Position, staff.UserName, staff.OverTime, staff.Fault, staff.SalaryReceived, staff.Sex, staff.CMND, staff.PhoneNumber, staff.Address, setcolor);
                        totalSalary += staff.SalaryReceived;
                        staffItem.onEdit += Item_OnEdit;
                        staffItem.onDel += StaffItem_onDel;
                        staffItem.onOverTimeValueChanged += StaffItem_onOverTimeValueChanged;
                        staffItem.onFaultChanged += StaffItem_onFaultChanged;
                        staffItem.Tag = staff;

                        flowLayoutPanelStaff.Controls.Add(staffItem);
                        staffItems.Add(staffItem);
                        sizeChange();
                    }
                }
            }
            this.SetBackGround();
        }

        private void flowLayoutPanelStaff_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }

        private void btSetSalary_Click(object sender, EventArgs e)
        {
            fSetSalary f = new fSetSalary();
            f.ShowDialog();
            foreach (Control item in this.flowLayoutPanelStaff.Controls)
            {
                (item as StaffItem).UpdateSalaryReceived();
            }    
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelStaff.Controls.Count > 0)
            {
                StaffDAL.Instance.ResetOverandFault();
                BillDAL.Instance.UpdateBillSalary(username, totalSalary * -1);
                MessageBox.Show("Kết toán lương thành công");
                foreach (Control item in this.flowLayoutPanelStaff.Controls)
                {
                    (item as StaffItem).SALARYRECEIVED = PositionDAL.Instance.GetSalarybyPosition((item as StaffItem).POSITION).ToString();
                    (item as StaffItem).OVERTIME = 0;
                    (item as StaffItem).FAULT = 0;
                }    
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
        private void fStaff_Load(object sender, EventArgs e)
        {
            this.LoadStaff();
        }
        #endregion


    }
}
