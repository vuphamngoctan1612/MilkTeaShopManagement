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

namespace MilkTeaHouseProject.GUI
{
    public partial class fSwapTable : Form
    {
        public string IDTable1;
        public string IDTable2;
        public string NAMETABLE;
        public int FLAG;

        public fSwapTable(string IDTable, bool status)
        {
            InitializeComponent();

            DropShadow dr = new DropShadow();
            dr.ApplyShadows(this);

            //cbGroup.SelectedIndex = 0;
            IDTable1 = IDTable;
            NAMETABLE = TableFoodDAL.Instance.GetNamebyIdTable(int.Parse(IDTable1));
            FLAG = 0;
            LoadRoom();
            lbTableNameSelected.Text = string.Format("Đổi bàn {0}", NAMETABLE);
        }

        public void LoadRoom()
        {
            List<GroupTable> groups = GroupTableDAL.Instance.GetListGroupTable();

            foreach (GroupTable item in groups)
            {
                cbGroup.Items.Add(item.Name);
            }

            string nameGroup = TableFoodDAL.Instance.GetNameGroupbyIdTable(int.Parse(IDTable1));

            if (cbGroup.Items.Count == 1)
            {
                cbGroup.SelectedIndex = 0;
            }
            else
            for (int i = 0; i < cbGroup.Items.Count; i++)
            {
                if (cbGroup.Items[i].ToString() != nameGroup)
                {
                    cbGroup.Text = cbGroup.Items[i].ToString();
                    break;
                }
            }
        }

        public void LoadTable(string nameRoom)
        {
            cbTable.DataSource = TableFoodDAL.Instance.GetNamesTablebyGroupTable(nameRoom, NAMETABLE);

            cbTable.DisplayMember = "Name";

            cbID.DataSource = TableFoodDAL.Instance.GetIDsTablebyGroupTable(nameRoom, NAMETABLE);

            cbID.DisplayMember = "ID";
        }

        private void ShowError(Control control, string error)
        {
            control.Focus();
            errorShow.Visible = true;
            errorShow.Location = new Point(control.Location.X, control.Location.Y + control.Height);
            errorShow.Text = error;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbTable.Text))
            {
                int idBill1 = BillDAL.Instance.GetBillIdbyTableID(int.Parse(IDTable1));
                int idBill2 = BillDAL.Instance.GetBillIdbyTableID(int.Parse(cbID.Text));
                IDTable2 = cbID.Text;

                if (idBill1 != 0)
                {
                    if (idBill2 != 0)
                    {
                        BillDAL.Instance.UpdateTableID(int.Parse(IDTable1), idBill2);
                        BillDAL.Instance.UpdateTableID(int.Parse(cbID.Text), idBill1);
                        FLAG = 1;
                        this.Close();
                    }
                    else
                    {
                        BillDAL.Instance.UpdateTableID(int.Parse(cbID.Text), idBill1);
                        TableFoodDAL.Instance.SetStatusEmpty(int.Parse(IDTable1));
                        TableFoodDAL.Instance.SetStatusBusy(int.Parse(cbID.Text));
                        FLAG = 2;
                        this.Close();
                    }
                }
                else
                {
                    if (idBill2 != 0)
                    {
                        BillDAL.Instance.UpdateTableID(int.Parse(IDTable1), idBill2);
                        TableFoodDAL.Instance.SetStatusBusy(int.Parse(IDTable1));
                        TableFoodDAL.Instance.SetStatusEmpty(int.Parse(cbID.Text));
                        FLAG = 3;
                        this.Close();
                    }
                    else
                    {
                        ShowError(cbTable, "Hai bàn đều rỗng");
                    }
                }
            }
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTable(cbGroup.Text);
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbID.SelectedIndex = cbTable.SelectedIndex;

            errorShow.Visible = false;
        }
    }
}
