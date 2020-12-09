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

            if (sex == true)
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

            if (position == "Quản lí")
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
        }
        public event EventHandler onEdit = null;
        public event EventHandler onDel = null;
        public event EventHandler onOverTimeValueChanged = null;
        public event EventHandler onFaultChanged = null;


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
            if (this.Height == 50)
                Collapse();
            else
                Expand();
        }

        private void numericUpDownOverTime_ValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.lbID.Text);
            int overtime = int.Parse(this.numericUpDownOverTime.Value.ToString());

            StaffDAL.Instance.UpdateOverTime(id, overtime);

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

            if (onFaultChanged != null)
            {
                onFaultChanged.Invoke(this, new EventArgs());
            }
        }

        private void StaffItem_Click(object sender, EventArgs e)
        {
            if (this.Height == 50)
                this.Height = 250;
            else
                this.Height = 50;
        }

        private void StaffItem_Load(object sender, EventArgs e)
        {
            //Expand();
            Collapse();
        }

        public void Expand()
        {
            this.Height = 250;
            int space = this.Width / 3;
            picStaff.Width = picStaff.Height = 100;
            picStaff.Location = new Point(50, 90);

            this.gunaSeparator1.Visible = true;
            gunaSeparator1.Width = this.Width;
            gunaSeparator1.Location = new Point(0, 50);

            panel1.Location = new Point(250, 80);
        }

        public void Collapse()
        {
            this.Height = 50;
            this.gunaSeparator1.Visible = false;
            int space = this.Width / 8;
            picStaff.Width = picStaff.Height = 45;
            picStaff.Location = new Point(10, 3);
            lbID.Location = new Point(space, 15);
            lbName.Location = new Point((int)(space * 1.7), 15);
            lbPosition.Location = new Point((int)(space * 3), 15);
            lbUserName.Location = new Point((int)(space * 3.7), 15);
            numericUpDownOverTime.Location = new Point((int)(space * 4.9), 15);
            numericFault.Location = new Point((int)(space * 5.8), 15);
            lbSalary.Location = new Point((int)(space * 6.5), 15);
            btEdit.Location = new Point((int)(space * 7.2), 12);
            btDel.Location = new Point((int)(space * 7.2) + 50, 12);
        }
    }
}
