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
    public partial class fRoomTable : Form
    {
        private fOrder frmOrder2;

        public fRoomTable(fOrder frmOrder)
        {
            InitializeComponent();

            BringToHome();
            LoadTable();
            LoadSize();
            LoadAllGroup();

            flowLayoutPanelTable.Controls[0].Visible = false;
            frmOrder2 = frmOrder;

            frmOrder2.LoadTable();
        }

        #region Method
        public void LoadTable()
        {
            this.flowLayoutPanelTable.Controls.Clear();
            List<TableFood> tables = TableFoodDAL.Instance.LoadTable();

            foreach (TableFood table in tables)
            {
                TableItem item;
                if (table.Status == true)
                    item = new TableItem(table.ID, table.Name, table.Status, table.NameGroup, Color.FromArgb(250, 204, 206));
                else
                    item = new TableItem(table.ID, table.Name, table.Status, table.NameGroup, Color.FromArgb(255, 255, 255));
                item.Tag = table;
                item.onChoose += TableItem_onChoose;

                this.flowLayoutPanelTable.Controls.Add(item);
            }
        }

        public void LoadLabelAllinGroup()
        {
            Label lbAll = new Label();
            lbAll.Text = "Tất cả";
            lbAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbAll.AutoSize = true;
            lbAll.Cursor = System.Windows.Forms.Cursors.Hand;

            lbAll.Click += lbAllinGroup_Click;
            lbAll.ForeColor = Color.FromArgb(0, 144, 218);
            this.flowLayoutPanelGroup.Controls.Add(lbAll);
        }

        public void LoadAllGroup()
        {
            flowLayoutPanelGroup.Controls.Clear();
            List<GroupTable> groups = GroupTableDAL.Instance.GetListGroupTable();

            LoadLabelAllinGroup();

            foreach (GroupTable group in groups)
            {
                Label lbGroup = LoadGroup(group.Name);

                this.flowLayoutPanelGroup.Controls.Add(lbGroup);
            }
        }

        public Label LoadGroup(string namegroup)
        {
            Label lbGroup = new Label();
            lbGroup.Text = namegroup;
            lbGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                                                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbGroup.AutoSize = true;
            lbGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            lbGroup.Tag = lbGroup;

            lbGroup.Click += LbGroup_Click;

            return lbGroup;
        }

        public void AddTable(int ID, string name, bool status, string nameGroup)
        {
            TableFood table = new TableFood(ID, name, status, nameGroup);
            TableItem item;
            if (table.Status == true)
                item = new TableItem(table.ID, table.Name, table.Status, table.NameGroup, Color.FromArgb(250, 204, 206));
            else
                item = new TableItem(table.ID, table.Name, table.Status, table.NameGroup, Color.FromArgb(255, 255, 255));
            item.Tag = table;
            item.onChoose += TableItem_onChoose;

            this.flowLayoutPanelTable.Controls.Add(item);
        }

        public void LoadStatusTrue(string tableid)
        {
            foreach (TableItem item in flowLayoutPanelTable.Controls)
            {
                if (item.ID.ToString() == tableid)
                {
                    item.BackColor = Color.FromArgb(250, 204, 206);
                    item.LoadBackColor(Color.FromArgb(250, 204, 206));
                    item.Status = true;
                    break;
                }
            }
        }

        public void LoadStatusFalse(string tableid)
        {
            foreach (TableItem item in flowLayoutPanelTable.Controls)
            {
                if (item.ID.ToString() == tableid)
                {
                    item.BackColor = Color.FromArgb(255, 255, 255);
                    item.LoadBackColor(Color.FromArgb(255, 255, 255));
                    item.ResetBackcolor();
                    item.Status = false;
                    break;
                }
            }
        }

        public void SearchTable(string search)
        {
            foreach (Control item in flowLayoutPanelTable.Controls)
            {
                string name = (item as TableItem).NameTable;
                if (!name.ToLower().Contains(search.ToLower()))
                {
                    item.Visible = false;
                }
                else
                {
                    item.Visible = true;
                }
            }
            flowLayoutPanelTable.Controls[0].Visible = false;
        }

        public void LoadSize()
        {
            int space = this.Width - 8 * flowLayoutPanelTable.Controls[0].Width - 18;

            foreach (Control item in flowLayoutPanelTable.Controls)
            {
                item.Margin = new Padding(space, 3, space, 3);
            }
        }

        public void BringToHome()
        {
            if (TableFoodDAL.Instance.GetMAXIDBill() == 0)
            {
                TableFoodDAL.Instance.AddBringtoHome();
            }
        }
        #endregion

        #region Event
        private void TableItem_onChoose(object sender, EventArgs e)
        {
            this.lbIDTable.Text = ((sender as TableItem).Tag as TableFood).ID.ToString();

            foreach (Control item in flowLayoutPanelTable.Controls)
            {
                (item as TableItem).Selected = false;
                (item as TableItem).ResetBackcolor();
            }

            (sender as TableItem).Selected = true;
            (sender as TableItem).ChangeBackcolor();

            if ((sender as TableItem).Status == false)
                this.btnDelTable.Visible = true;
            else
                this.btnDelTable.Visible = false;

            this.btnSwapTable.Visible = true;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            int id = TableFoodDAL.Instance.GetMAXIDBill() + 1;

            fAddTable frm = new fAddTable(id);
            frm.ShowDialog();

            if (frm.FLAG != 0)
            {
                if (frm.FLAG == 2)
                {
                    Label lb = LoadGroup(frm.NameGroup);
                    flowLayoutPanelGroup.Controls.Add(lb);
                    AddTable(frm.ID, frm.NameTable, frm.Status, frm.NameGroup);
                    frmOrder2.AddTable(frm.ID, frm.NameTable, frm.Status, frm.NameGroup);
                    frmOrder2.AddGroup(frm.NameGroup);
                }
                else
                if (frm.FLAG == 1)
                {
                    AddTable(frm.ID, frm.NameTable, frm.Status, frm.NameGroup);
                    frmOrder2.AddTable(frm.ID, frm.NameTable, frm.Status, frm.NameGroup);
                }
            }
        }

        private void btnSwapTable_Click(object sender, EventArgs e)
        {
            fSwapTable frm = new fSwapTable(lbIDTable.Text, TableFoodDAL.Instance.GetStatusbyIdTable(int.Parse(lbIDTable.Text)));

            frm.ShowDialog();

            if (frm.FLAG == 2)
            {
                LoadStatusFalse(frm.IDTable1);
                LoadStatusTrue(frm.IDTable2);
            }
            else if (frm.FLAG == 3)
            {
                LoadStatusFalse(frm.IDTable2);
                LoadStatusTrue(frm.IDTable1);
            }

            this.btnDelTable.Visible = false;
            this.btnSwapTable.Visible = false;

            if (frm.FLAG != 0)
                this.btnSwapTable.Visible = false;
            frmOrder2.btn_Click(sender, e);
        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            TableFoodDAL.Instance.DeleteTable(int.Parse(lbIDTable.Text));

            for (int i = 1; i < flowLayoutPanelTable.Controls.Count; i++)
            {
                if ((flowLayoutPanelTable.Controls[i] as TableItem).ID.ToString() == lbIDTable.Text)
                {
                    flowLayoutPanelTable.Controls.RemoveAt(i);
                    frmOrder2.RemoveTable(i);
                }
            }

            btnSwapTable.Visible = btnDelTable.Visible = false;
        }

        private void lbAllinGroup_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanelTable.Controls)
            {
                item.Visible = true;
            }

            flowLayoutPanelTable.Controls[0].Visible = false;

            foreach (Control control in this.flowLayoutPanelGroup.Controls)
            {
                control.ForeColor = Color.Black;
            }

            (sender as Label).ForeColor = Color.FromArgb(0, 144, 218);
        }

        private void LbGroup_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanelTable.Controls)
            {
                item.Visible = true;
            }

            foreach (Control control in this.flowLayoutPanelGroup.Controls)
            {
                control.ForeColor = Color.Black;
            }

            (sender as Label).ForeColor = Color.FromArgb(0, 144, 218);

            string nameGroup = (sender as Label).Text;

            foreach (Control item in flowLayoutPanelTable.Controls)
            {
                if (((item as TableItem).Tag as TableFood).NameGroup != nameGroup)
                    item.Visible = false;
            }
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            fDelRoom frm = new fDelRoom();

            frm.ShowDialog();

            if (frm.flag == true)
            {
                for (int i = 0; i < flowLayoutPanelGroup.Controls.Count; i++)
                {
                    if (flowLayoutPanelGroup.Controls[i].Text == frm.nameGroup)
                    {
                        flowLayoutPanelGroup.Controls.RemoveAt(i);
                    }
                }

                for (int i = 0; i < flowLayoutPanelTable.Controls.Count; i++)
                {
                    if ((flowLayoutPanelTable.Controls[i] as TableItem).NameGroup == frm.nameGroup)
                    {
                        flowLayoutPanelTable.Controls.RemoveAt(i);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTable(txtSearch.Text);
        }

        #endregion
    }
}
