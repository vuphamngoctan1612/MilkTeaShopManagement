using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
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
        private string username;
        private int billID = BillDAL.Instance.GetMAXIDBill() + 1;

        public fOrder(string username)
        {
            InitializeComponent();

            this.username = username;
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
            List<Drink> drinks = DrinkDAL.Instance.GetListDrinkbyCategory(category);

            foreach (Drink drink in drinks)
            {
                DrinkItem item = new DrinkItem(drink.Name, drink.Price, drink.Image);
                item.Tag = drink;
                item.onChoose += DrinkItem_onChoose;

                this.flowLayoutPanelDrinks.Controls.Add(item);
            }

            LoadSizeDrinḳ();
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
                DrinkItem drinkItem = new DrinkItem(drink.Name, drink.Price, drink.Image);
                drinkItem.Tag = drink;
                drinkItem.onChoose += DrinkItem_onChoose;

                this.flowLayoutPanelDrinks.Controls.Add(drinkItem);
            }

            LoadSizeDrinḳ();
        }

        public void SearchDrink(string search)
        {
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();
            this.flowLayoutPanelDrinks.Controls.Clear();

            foreach (Drink drink in drinks)
            {
                string name = drink.Name;
                if (name.ToLower().Contains(this.txtSearch.Text.ToLower()))
                {
                    DrinkItem item = new DrinkItem(name, drink.Price, drink.Image);
                    item.Tag = drink;
                    item.onChoose += DrinkItem_onChoose;

                    this.flowLayoutPanelDrinks.Controls.Add(item);
                }

                LoadSizeDrinḳ();
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
            List<TableFood> tables = TableFoodDAL.Instance.LoadTable();

            foreach (TableFood table in tables)
            {
                TableItem item = new TableItem(table.ID, table.Name, table.Status);
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

        public void LoadAllGroup()
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

        public void LoadGroup()
        {
            flowLayoutPanelGroup.Controls.Clear();
            List<GroupTable> groups = GroupTableDAL.Instance.GetListGroupTable();

            LoadAllGroup();

            foreach (GroupTable group in groups)
            {
                Label lbGroup = new Label();
                lbGroup.Text = group.Name;
                lbGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                                                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbGroup.AutoSize = true;
                lbGroup.Cursor = System.Windows.Forms.Cursors.Hand;
                lbGroup.Tag = lbGroup;

                lbGroup.Click += LbGroup_Click;

                this.flowLayoutPanelGroup.Controls.Add(lbGroup);
            }
        }

        private void ActiveBtnTable()
        {
            this.pnContainDrink.Visible = false;
            this.PnContainTable.Visible = true;

            this.btnDrink.BaseColor = Color.FromArgb(0, 144, 218);
            this.btnDrink.ForeColor = Color.FromArgb(255, 255, 255);

            this.btnTable.BaseColor = Color.FromArgb(255, 255, 255);
            this.btnTable.ForeColor = Color.FromArgb(0, 144, 218);
        }

        private void ActiveBtnDrink()
        {
            this.PnContainTable.Visible = false;
            this.pnContainDrink.Visible = true;

            this.btnTable.BaseColor = Color.FromArgb(0, 144, 218);
            this.btnTable.ForeColor = Color.FromArgb(255, 255, 255);

            this.btnDrink.BaseColor = Color.FromArgb(255, 255, 255);
            this.btnDrink.ForeColor = Color.FromArgb(0, 144, 218);
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

            if (((sender as TableItem).Tag as TableFood).Status == true)
            {
                int idBillByTableID = BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text));

                LoadBill(BillDAL.Instance.GetBillIdbyTableID(int.Parse(tableID.Text)));

                foreach (Control item in flowLayoutPanelBill.Controls)
                {
                    (item as BillItem).FalseVisibleDel();
                }
                this.btnCancel.Text = "Hủy bàn";
                this.btnPay.Visible = false;

                this.lbCount.Text = MenuDAL.Instance.GetCount(idBillByTableID).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(idBillByTableID)).ToString();
            }
            else
            {
                LoadBill(this.billID);
                this.btnCancel.Text = "Hủy đơn";
                this.btnPay.Visible = true;

                this.lbCount.Text = MenuDAL.Instance.GetCount(this.billID).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(this.billID)).ToString();
            
            }

            if (((sender as TableItem).Tag as TableFood).Name == "Mang về")
            {
                this.btnDeleteTable.Visible = false;
            }
            else
            {
                this.btnDeleteTable.Visible = true;
            }
        }

        private void DrinkItem_onChoose(object sender, EventArgs e)
        {
            int idDrink = ((sender as DrinkItem).Tag as Drink).ID;

            if (((sender as DrinkItem).Tag as Drink).Count > BillInfoDAL.Instance.GetCountbyDrinkBillID(this.billID, idDrink))
            {
                try
                {
                    int idStaff = StaffDAL.Instance.GetStaffIDbyUsername(this.Username);
                    int count = 1;

                    if (!BillDAL.Instance.ExistBillbyIDBill(this.billID))
                        BillDAL.Instance.InsertBill(this.billID, idStaff);

                    BillInfoDAL.Instance.InsertBillInfo(this.billID, idDrink, count);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
                finally
                {
                    this.lbCount.Text = MenuDAL.Instance.GetCount(this.billID).ToString();
                    this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(this.billID)).ToString();
                    LoadBill(this.billID);
                }
            }
            else
            {
                MessageBox.Show("Món này đã hết hàng");
            }
        }

        private void BillItem_onDel(object sender, EventArgs e)
        {
            try
            {
                int drinkID = ((sender as BillItem).Tag as DTO.Menu).IdDrink;

                BillInfoDAL.Instance.DeleteBillInfobyIDDrink(drinkID, billID);

                this.lbCount.Text = MenuDAL.Instance.GetCount(billID).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(billID)).ToString();
            }
            catch
            {

            }
            finally
            {

                this.flowLayoutPanelBill.Controls.Clear();
                LoadBill(this.billID);
            }
        }

        private void BillItem_onValueChanged(object sender, EventArgs e)
        {
            this.lbCount.Text = MenuDAL.Instance.GetCount(billID).ToString();
            this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(billID)).ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanelBill.Controls.Count > 0)
            {
                int totalPrice = MenuDAL.Instance.GetTotalPrice(billID);
                int staffID = StaffDAL.Instance.GetStaffIDbyUsername(this.Username);

                fInvoice invoice = new fInvoice(this.Username, billID, totalPrice, staffID, int.Parse(tableID.Text));
                invoice.ShowDialog();

                if (BillDAL.Instance.GetStatusbyIDBill(billID) == true)
                {
                    this.lbCount.Text = "0";
                    this.lbTotalPrice.Text = "0";

                    LoadTable();
                    LoadDrink();

                    TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
                    flowLayoutPanelBill.Controls.Clear();

                    billID += 1;
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn không tồn tại!", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text != "Hủy bàn")
            {
                if (this.flowLayoutPanelBill.Controls.Count != 0)
                {
                    try
                    {
                        BillInfoDAL.Instance.DeleteBillInfobyIDBill(billID);
                        BillDAL.Instance.DeleteBill(billID);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        this.flowLayoutPanelBill.Controls.Clear();
                        this.lbCount.Text = "0";
                        this.lbTotalPrice.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Hóa đơn không tồn tại!", "Error");
                }
            }
            else
            {
                BillDAL.Instance.SetTableNullbyTableID(int.Parse(tableID.Text));
                TableFoodDAL.Instance.SetStatusEmpty(int.Parse(tableID.Text));

                LoadTable();
                flowLayoutPanelBill.Controls.Clear();

                this.btnCancel.Text = "Hủy đơn";
                this.btnPay.Visible = true;
            }

            TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
        }

        private void flowLayoutPanelDrinks_SizeChanged(object sender, EventArgs e)
        {
            LoadSizeDrinḳ();
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

            LoadDrink();
        }

        private void LbCategory_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.flowLayoutPanelCategory.Controls)
            {
                control.ForeColor = Color.Black;
            }

            (sender as Label).ForeColor = Color.FromArgb(0, 144, 218);

            this.flowLayoutPanelDrinks.Controls.Clear();

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
            if (flowLayoutPanelBill.Controls.Count > 0)
            {
                BillInfoDAL.Instance.DeleteBillInfobyIDBill(billID);
                BillDAL.Instance.DeleteBill(billID);

                flowLayoutPanelBill.Controls.Clear();
            }
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

            if (TableFoodDAL.Instance.GetStatusbyIdTable(int.Parse(tableID.Text)) == true)
            {
                LoadBill(this.billID);

                this.btnCancel.Text = "Hủy đơn";
                this.btnPay.Visible = true;

                TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
            }
        }

        private void fOrder_Load(object sender, EventArgs e)
        {
            ActiveBtnTable();
            BringToHome();

            LoadTable();
            LoadDrink();
            LoadCategory();
            LoadGroup();

            TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
            this.btnDeleteTable.Visible = false;
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

            LoadTable();
            LoadGroup();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text != "Hủy bàn")
            {
                if (this.flowLayoutPanelBill.Controls.Count != 0)
                {
                    try
                    {
                        BillInfoDAL.Instance.DeleteBillInfobyIDBill(billID);
                        BillDAL.Instance.DeleteBill(billID);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        this.flowLayoutPanelBill.Controls.Clear();
                        this.lbCount.Text = "0";
                        this.lbTotalPrice.Text = "0";
                    }
                }
            }
            else
            {
                BillDAL.Instance.SetTableNullbyTableID(int.Parse(tableID.Text));
                TableFoodDAL.Instance.SetStatusEmpty(int.Parse(tableID.Text));
                LoadTable();
                flowLayoutPanelBill.Controls.Clear();
                this.btnCancel.Text = "Hủy đơn";
                this.btnPay.Visible = true;
            }

            TableFoodDAL.Instance.DeleteTable(int.Parse(tableID.Text));

            LoadTable();

            TableItem_onChoose(this.flowLayoutPanelTable.Controls[0], e);
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


        #endregion
    }
}
