using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaHouseProject.GUI;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaHouseProject
{
    public partial class fOrder : Form
    {
        private bool flag = true;
        private string username;
        private int staffID;
        private int billID = BillDAL.Instance.GetMAXIDBill() + 1;
        private fRoomTable frmRoom;
        private fMenu frmMenu;

        public fOrder(string username)
        {
            InitializeComponent();

            this.username = username;
            this.staffID = StaffDAL.Instance.GetStaffIDbyUsername(this.Username);
        }

        #region Methods
        public string Username { get => username; set => username = value; }

        public void LoadCategory()
        {
            List<Category> categories = CategoryDAL.Instance.GetListCategory();

            foreach (Category category in categories)
            {
                Label lbCategory = new Label();
                lbCategory.Text = category.Name;
                lbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                                                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbCategory.AutoSize = true;
                lbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
                lbCategory.Tag = lbCategory;

                lbCategory.Click += LbCategory_Click;

                this.flowLayoutPanelCategory.Controls.Add(lbCategory);
            }
        }

        public void LoadDrinkbyCategory(string category)
        {
            if (category != lbAll.Text)
            {
                foreach (Control item in flowLayoutPanelDrinks.Controls)
                {
                    if ((item as DrinkItem).CATEGORY != category)
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        item.Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control item in flowLayoutPanelDrinks.Controls)
                {
                    item.Visible = true;
                }
            }
        }

        public void LoadBill(int billID)
        {
            flowLayoutPanelBill.Controls.Clear();
            List<DTO.Menu> listMenu = MenuDAL.Instance.GetListMenu(billID);

            foreach (DTO.Menu menu in listMenu)
            {
                BillItem billItem = new BillItem(menu.IdDrink, menu.DrinkName, menu.Price, menu.Count, billID);

                billItem.onValueChanged += BillItem_onValueChanged;
                billItem.onDel += BillItem_onDel;
                billItem.FLAG = true;

                billItem.Tag = menu;
                billItem.Width = flowLayoutPanelBill.Width;

                this.flowLayoutPanelBill.Controls.Add(billItem);
            }
        }

        public void LoadDrink()
        {
            this.flowLayoutPanelDrinks.Controls.Clear();
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();

            foreach (Drink drink in drinks)
            {
                DrinkItem drinkItem = new DrinkItem(drink.Name, drink.Price, drink.Image, drink.Category);
                drinkItem.Tag = drink;
                drinkItem.onChoose += DrinkItem_onChoose;

                this.flowLayoutPanelDrinks.Controls.Add(drinkItem);
            }

            LoadSizeDrinḳ();
        }

        public void SearchDrink(string search)
        {
            foreach (Control drink in flowLayoutPanelDrinks.Controls)
            {
                string name = (drink as DrinkItem).NAME;
                if (!name.ToLower().Contains(search.ToLower()))
                {
                    drink.Visible = false;
                }
                else
                {
                    drink.Visible = true;
                }
            }
        }

        public void LoadSizeDrinḳ()
        {
            double space = (int)(this.flowLayoutPanelDrinks.Width / 4.7);

            foreach (Control item in flowLayoutPanelDrinks.Controls)
            {
                item.Width = (int)space;
                item.Height = (int)(space / 3 * 4);
            }
        }

        public void LoadTable()
        {
            this.flowLayoutPanelTable.Controls.Clear();
            this.flowLayoutPanelBill.Controls.Clear();
            List<TableFood> tables = TableFoodDAL.Instance.LoadTable();
            Color color = Color.FromArgb(255, 255, 255);

            foreach (TableFood table in tables)
            {
                TableItem item = new TableItem(table.ID, table.Name, table.Status, table.NameGroup, color);
                item.Tag = table;
                item.onChoose += TableItem_onChoose;


                this.flowLayoutPanelTable.Controls.Add(item);
            }
        }

        public void BringToHome()
        {
            if (TableFoodDAL.Instance.GetMAXIDBill() == 0)
            {
                TableFoodDAL.Instance.AddBringtoHome();
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

        private void ActiveBtnTable()
        {
            this.pnContainDrink.Visible = false;
            this.PnContainTable.Visible = true;
            this.pnSearch.Visible = false;

            this.btnDrink.BaseColor = Color.FromArgb(0, 144, 218);
            this.btnDrink.ForeColor = Color.FromArgb(255, 255, 255);

            this.btnTable.BaseColor = Color.FromArgb(255, 255, 255);
            this.btnTable.ForeColor = Color.FromArgb(0, 144, 218);
        }

        private void ActiveBtnDrink()
        {
            this.PnContainTable.Visible = false;
            this.pnContainDrink.Visible = true;
            this.pnSearch.Visible = true;

            this.btnTable.BaseColor = Color.FromArgb(0, 144, 218);
            this.btnTable.ForeColor = Color.FromArgb(255, 255, 255);

            this.btnDrink.BaseColor = Color.FromArgb(255, 255, 255);
            this.btnDrink.ForeColor = Color.FromArgb(0, 144, 218);
        }

        public int ConvertToNumber(string str)
        {
            string[] s = str.Split(',');
            string tmp = "";
            foreach (string a in s)
            {
                tmp = tmp + a;
            }
            return int.Parse(tmp);
        }

        private void ShowError(string error)
        {
            lbSuccess.Visible = false;
            lbErrorShow.Visible = true;
            lbErrorShow.Text = error;
            pnTotal.BackColor = Color.FromArgb(255, 233, 171);
        }

        private void ShowSuccess(string query)
        {
            lbSuccess.Visible = true;
            lbErrorShow.Visible = false;
            lbSuccess.Text = query;
            pnTotal.BackColor = Color.FromArgb(172, 234, 156);
        }

        public void AddTable(int ID, string name, bool status, string nameGroup)
        {
            Color color = Color.FromArgb(255, 255, 255);
            TableFood table = new TableFood(ID, name, status, nameGroup);
            TableItem item = new TableItem(table.ID, table.Name, table.Status, table.NameGroup, color);
            item.Tag = table;
            item.onChoose += TableItem_onChoose;

            this.flowLayoutPanelTable.Controls.Add(item);
        }

        public void AddGroup(string name)
        {
            Label lb = LoadGroup(name);
            flowLayoutPanelGroup.Controls.Add(lb);
        }

        public void RemoveTable(int i)
        {
            flowLayoutPanelTable.Controls.RemoveAt(i);
        }

        public void LoadFormRoom(fRoomTable frmRoomTable)
        {
            frmRoom = frmRoomTable;
        }

        public void LoadFormMenu(fMenu formMenu)
        {
            frmMenu = formMenu;
            frmMenu.LoadMenu();
        }
        #endregion

        #region Events
        private void TableItem_onChoose(object sender, EventArgs e)
        {
            this.lbTableSelected.Text = ((sender as TableItem).Tag as TableFood).Name;
            this.tableID.Text = ((sender as TableItem).Tag as TableFood).ID.ToString();

            foreach (Control item in flowLayoutPanelTable.Controls)
            {
                (item as TableItem).Selected = false;
                (item as TableItem).ResetBackcolor();
            }

            (sender as TableItem).Selected = true;
            (sender as TableItem).ChangeBackcolor();

            if (TableFoodDAL.Instance.GetStatusbyIdTable(int.Parse(tableID.Text)) == true)
            {
                int idBillByTableID = BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text));

                if (idBillByTableID != 0)
                {
                    LoadBill(idBillByTableID);

                    foreach (BillItem item in flowLayoutPanelBill.Controls)
                    {
                        item.FLAG = false;
                    }
                }

                this.btnPay.Visible = true;
                this.btnCancel.Enabled = true;
                this.btnCancel.Text = "Hủy đơn";

                this.lbCount.Text = MenuDAL.Instance.GetCount(idBillByTableID).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(idBillByTableID)).ToString();
            }
            else
            {
                flowLayoutPanelBill.Controls.Clear();

                this.btnPay.Visible = false;
                this.btnCancel.Enabled = false;

                this.lbCount.Text = "0";
                this.lbTotalPrice.Text = "0";
            }

        }

        private void DrinkItem_onChoose(object sender, EventArgs e)
        {
            int idDrink = ((sender as DrinkItem).Tag as Drink).ID;
            int idBill;
            int count = 1;
            long price = ((sender as DrinkItem).Tag as Drink).Price;

            if (DrinkDAL.Instance.GetCountbyDrinkID(idDrink) > 0)
            {
                if (TableFoodDAL.Instance.GetStatusbyIdTable(int.Parse(tableID.Text)) == true)
                {
                    idBill = BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text));

                    BillInfoDAL.Instance.InsertBillInfo(idBill, idDrink, count);

                    BillDAL.Instance.UpdateBill(idBill, price);
                }
                else
                {
                    idBill = this.billID;

                    if (!BillDAL.Instance.ExistBillbyIDBill(idBill))
                        BillDAL.Instance.InsertBill(idBill, this.staffID, tableID.Text, price);

                    BillInfoDAL.Instance.InsertBillInfo(idBill, idDrink, count);

                    TableFoodDAL.Instance.UpdateTable(int.Parse(tableID.Text));

                    frmRoom.LoadStatusTrue(tableID.Text);

                    this.billID = BillDAL.Instance.GetMAXIDBill() + 1;

                }
                this.btnPay.Visible = true;
                this.btnCancel.Text = "Hủy đơn";
                this.btnCancel.Visible = true;
                this.btnCancel.Enabled = true;

                DrinkDAL.Instance.MinusCount(idDrink);

                this.lbCount.Text = MenuDAL.Instance.GetCount(idBill).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(idBill)).ToString();

                LoadBill(idBill);

                foreach (BillItem item in flowLayoutPanelBill.Controls)
                {
                    item.FLAG = false;
                }
            }
            else
            {
                ShowError("Món này đã hết hàng");
            }
        }

        private void BillItem_onDel(object sender, EventArgs e)
        {
            int idBill = BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text));
            int drinkID = ((sender as BillItem).Tag as DTO.Menu).IdDrink;
            int count = ((sender as BillItem).Tag as DTO.Menu).Count;
            long oldTotal = ((sender as BillItem).Tag as DTO.Menu).Price * count;

            try
            {
                BillInfoDAL.Instance.DeleteBillInfobyIDDrink(drinkID, idBill);
                DrinkDAL.Instance.SetCountbyID(drinkID, count);
                BillDAL.Instance.UpdateTotalBill(idBill, oldTotal);

                this.lbCount.Text = MenuDAL.Instance.GetCount(idBill).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(idBill)).ToString();
            }
            catch
            {

            }
            finally
            {
                LoadBill(idBill);
                ShowSuccess("Đã hủy món");
                flowLayoutPanelBill.Controls.Remove(sender as BillItem);
            }
        }

        private void BillItem_onValueChanged(object sender, EventArgs e)
        {
            if ((sender as BillItem).FLAG == false)
            {
                this.lbCount.Text = MenuDAL.Instance.GetCount(BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text))).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text)))).ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int idBill = BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text));

            if (this.flowLayoutPanelBill.Controls.Count > 0)
            {
                long totalPrice = MenuDAL.Instance.GetTotalPrice(idBill);

                fInvoice invoice = new fInvoice(this.Username, idBill, totalPrice, staffID, int.Parse(tableID.Text));
                invoice.ShowDialog();

                if (BillDAL.Instance.GetStatusbyIDBill(idBill) == true)
                {
                    this.lbCount.Text = "0";
                    this.lbTotalPrice.Text = "0";

                    ShowSuccess("Thanh toán thành công");
                    frmRoom.LoadStatusFalse(tableID.Text);
                    frmRoom.LoadTable();
                    TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
                    frmMenu.LoadCount();
                }
            }
            else
            {
                ShowError("Hóa đơn không tồn tại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            try
            {
                int idBill = BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text));

                foreach (Control item in flowLayoutPanelBill.Controls)
                {
                    int drinkID = ((item as BillItem).Tag as DTO.Menu).IdDrink;
                    int count = ((item as BillItem).Tag as DTO.Menu).Count;

                    BillInfoDAL.Instance.DeleteBillInfobyIDDrink(drinkID, idBill);
                    DrinkDAL.Instance.SetCountbyID(drinkID, count);
                }

                BillDAL.Instance.DeleteBill(idBill);

                TableFoodDAL.Instance.SetStatusEmpty(int.Parse(tableID.Text));

                frmRoom.LoadStatusFalse(tableID.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                ShowSuccess("Đã hủy đơn");
                this.lbCount.Text = "0";
                this.lbTotalPrice.Text = "0";
            }

            TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
        }

        private void flowLayoutPanelDrinks_SizeChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void lbAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.flowLayoutPanelCategory.Controls)
            {
                control.ForeColor = Color.Black;
            }

            this.lbAll.ForeColor = Color.FromArgb(0, 144, 218);

            LoadDrinkbyCategory(lbAll.Text);
        }

        private void LbCategory_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.flowLayoutPanelCategory.Controls)
            {
                control.ForeColor = Color.Black;
            }

            (sender as Label).ForeColor = Color.FromArgb(0, 144, 218);

            LoadDrinkbyCategory(((sender as Label).Tag as Label).Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDrink(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDrink(txtSearch.Text);
        }

        private void fOrder_FormClosed(object sender, FormClosedEventArgs e)
        {

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

        private void btnTable_Click(object sender, EventArgs e)
        {
            ActiveBtnTable();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            ActiveBtnDrink();
        }

        private void fOrder_Load(object sender, EventArgs e)
        {
            ActiveBtnTable();
            BringToHome();

            LoadTable();
            LoadDrink();
            LoadCategory();
            LoadAllGroup();

            TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
        }

        private void fOrder_SizeChanged(object sender, EventArgs e)
        {
            int width = this.Width - (pnLeft.Width + pnRight.Width + gunaElipsePanel1.Width + pnCenter.Width);
            int height = this.Height - pnTop.Height;

            this.pnContainDrink.Width = this.PnContainTable.Width = width;
            this.PnContainTable.Height = this.pnContainDrink.Height = height;

            this.pnContainDrink.Location = new Point(10, this.pnTop.Height);
            this.PnContainTable.Location = new Point(10, this.pnTop.Height);

            foreach (Control item in pnContainDrink.Controls)
            {
                item.Width = width;
            }

            LoadSizeDrinḳ();

            this.panel2.Height = this.panel3.Height = this.btnPay.Height / 3;
            this.pnSearch.Location = new Point(this.pnCenter.Location.X - this.pnSearch.Width, this.pnSearch.Location.Y);
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
                }
                else
                if (frm.FLAG == 1)
                {
                    AddTable(frm.ID, frm.NameTable, frm.Status, frm.NameGroup);
                }
                ShowSuccess("Thêm bàn thành công");
            }
        }

        private void lbAllinGroup_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbErrorShow.Visible = false;
            lbSuccess.Visible = false;
            this.pnTotal.BackColor = Color.FromArgb(255, 233, 171);
        }

        public void btn_Click(object sender, EventArgs e)
        {
            foreach (TableItem item in flowLayoutPanelTable.Controls)
            {
                if (item.Selected == true)
                {
                    TableItem_onChoose(item, e);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                this.billID = BillDAL.Instance.GetMAXIDBill() + 1;
            }
            catch (SqlException)
            {
                if (flag == true)
                {
                    flag = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                    timer2.Dispose();
                    return;
                }
            }
        }
        #endregion
    }
}
