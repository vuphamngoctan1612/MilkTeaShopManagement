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
    public partial class ItemInBill : UserControl
    {
        public ItemInBill()
        {
            InitializeComponent();
        }


        public ItemInBill(int ID, DateTime checkout, int staffID, string Staffname, string note, int total, bool setcolor)
        {
            InitializeComponent();

            this.lbID.Text = ID.ToString();
            this.lbDate.Text = checkout.ToString("dd/M/yyyy");
            if (staffID < 1)
                this.lbStaffID.Text = "Nhân viên đã nghỉ";
            else
                this.lbStaffID.Text = staffID.ToString();
            if (Staffname != "null")
                this.lbStaffName.Text = Staffname;
            else
                this.lbStaffName.Text = "";
            this.lbNote.Text = note;
            this.lbTotal.Text = string.Format("{0:n0}", total).ToString();
            if (setcolor == true)
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        #region Methods
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

        void sizeChange()
        {
            int space = this.Width / 7;
            this.lbID.Location = new Point(50, 10);
            this.lbDate.Location = new Point(space, 10);
            if (lbStaffID.Text == "Nhân viên đã nghỉ")
                this.lbStaffID.Location = new Point((int)(space * 1.9), 10);
            else
                this.lbStaffID.Location = new Point((int)(space * 2.3), 10);
            this.lbStaffName.Location = new Point(space * 3, 10);
            this.lbNote.Location = new Point((int)(space * 4.3), 10);
            this.lbTotal.Location = new Point((int)(space * 6.3), 10);
        }
        #endregion

        #region Event
        private void ItemInBill_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }
        #endregion
    }
}
