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
    public partial class StaffItem : UserControl
    {
        public string NAME { get => this.lbName.Text; }
        public long OVERTIME { get => this.numericUpDownOverTime.Value; set => this.numericUpDownOverTime.Value = value; }
        public long FAULT { get => this.numericFault.Value; set => this.numericFault.Value = value; }
        public string SALARYRECEIVED { get => this.lbSalary.Text; set => this.lbSalary.Text = value; }
        public string POSITION { get => this.lbPosition.Text; set => this.lbPosition.Text = value; }
        public StaffItem()
        {
            InitializeComponent();
        }
        public StaffItem(int id, string name, byte[] image, DateTime birthdate, string position, string userName, int overtime, int fault, int salaryReceived, bool sex, string cmnd, string phone, string address, bool setcolor)
        {
            InitializeComponent();
            this.lbID.Text = id.ToString();
            this.lbName.Text = NameShow.Text = name;
            this.BirthShow.Text = birthdate.ToString("dd/M/yyyy");
            this.lbPosition.Text = PosShow.Text = position;
            this.lbUserName.Text = userName;
            this.numericUpDownOverTime.Value = overtime;
            this.numericFault.Value = fault;
            this.lbSalary.Text = string.Format("{0:n0}", salaryReceived).ToString();
            this.PhoneShow.Text = phone;
            this.AddressShow.Text = address;
            this.CMNDShow.Text = cmnd;

            if (sex)
            {
                this.SexShow.Text = "Nam";
            }
            else
            {
                this.SexShow.Text = "Nữ";
            }

            if (image == null)
            {
                this.picStaff.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(image);
                picStaff.Image = Image.FromStream(mstream);
                picStaff.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (position.ToUpper() == "QUẢN LÝ")
            {
                this.btEdit.Visible = false;
                this.btDel.Visible = false;
                this.numericUpDownOverTime.Visible = false;
                this.numericFault.Visible = false;
                this.lbSalary.Visible = false;
            }
            if (setcolor == true)
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }

            gunaPictureBox1.Image = picStaff.Image;
        }
        public event EventHandler onEdit = null;
        public event EventHandler onDel = null;
        public event EventHandler onOverTimeValueChanged = null;
        public event EventHandler onFaultChanged = null;


        void SizeLoad()
        {
            int space = this.Width / 8;
            picStaff.Width = picStaff.Height = 50;
            picStaff.Location = new Point(10, 10);
            lbID.Location = new Point(130, 20);
            lbName.Location = new Point((int)(space * 1.7), 20);
            lbPosition.Location = new Point((int)(space * 3.2), 20);
            lbUserName.Location = new Point((int)(space * 4.2), 20);
            numericUpDownOverTime.Location = new Point((int)(space * 5.5), 20);
            numericFault.Location = new Point((int)(space * 6.5), 20);
            lbSalary.Location = new Point((int)(space * 7.2), 20);
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (onEdit != null)
            {
                onEdit.Invoke(this, new EventArgs());
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (onDel != null)
            {
                onDel.Invoke(this, new EventArgs());
            }
        }

        private void StaffItem_SizeChanged(object sender, EventArgs e)
        {
            SizeLoad();
        }

        private void numericUpDownOverTime_ValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbID.Text);
            int overtime = int.Parse(this.numericUpDownOverTime.Value.ToString());
            StaffDAL.Instance.UpdateOverTime(id, overtime);
            this.UpdateSalaryReceived();

            if (onOverTimeValueChanged != null)
            {
                onOverTimeValueChanged.Invoke(this, new EventArgs());
            }

        }
        private void numericFault_ValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbID.Text);
            int fault = (int)this.numericFault.Value;
            StaffDAL.Instance.UpdateFault(id, fault);
            this.UpdateSalaryReceived();

            if (onFaultChanged != null)
            {
                onFaultChanged.Invoke(this, new EventArgs());
            }
        }

        private void StaffItem_Click(object sender, EventArgs e)
        {
            if (this.Height == 70)
                Expand();
            else
                Collapse();
        }

        private void StaffItem_Load(object sender, EventArgs e)
        {
            //Expand();
            Collapse();
        }

        public void Expand()
        {
            this.Height = 400;
            int space = this.Width / 3;

            this.gunaSeparator1.Visible = true;
        }

        public void Collapse()
        {
            this.Height = 70;
            this.gunaSeparator1.Visible = false;

            SizeLoad();
        }
        public void UpdateStaffItem(int id)
        {
            Staff staff = StaffDAL.Instance.GetStaffById(id);

            this.lbID.Text = staff.ID.ToString();
            this.lbName.Text = NameShow.Text = staff.Name.ToString();
            this.BirthShow.Text = staff.BirthDate.ToString();
            this.lbPosition.Text = PosShow.Text = staff.Position;
            this.lbUserName.Text = staff.UserName;
            this.lbSalary.Text = string.Format("{0:n0}", staff.SalaryReceived).ToString();
            this.PhoneShow.Text = staff.PhoneNumber;
            this.AddressShow.Text = staff.Address;
            this.CMNDShow.Text = staff.CMND;
            if (staff.Image == null)
            {
                this.picStaff.Image = null;
                this.gunaPictureBox1.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(staff.Image);
                picStaff.Image = Image.FromStream(mstream);
                picStaff.SizeMode = PictureBoxSizeMode.StretchImage;
                gunaPictureBox1.Image = Image.FromStream(mstream);

            }
        }
        public void UpdateSalaryReceived()
        {
            List<Position> positions = PositionDAL.Instance.GetListPosistion();
            int id = int.Parse(this.lbID.Text);
            string pos = this.lbPosition.Text;
            Staff staff = StaffDAL.Instance.GetStaffById(id);

            foreach (Position position in positions)
            {
                if (position.Name == pos)
                {
                    int salaryReceived = 0;
                    salaryReceived = position.Salary + staff.OverTime * position.OverTimeSalary - staff.Fault * position.MinusSalary;
                    StaffDAL.Instance.UpdateSalaryReceived(staff.ID, salaryReceived);
                    this.lbSalary.Text = string.Format("{0:n0}", salaryReceived).ToString();
                }
            }
        }
    }
}
