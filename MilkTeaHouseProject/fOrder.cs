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

            LoadDrink();
            LoadCategory();
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

        public void LoadBill()
        {
            List<DTO.Menu> listMenu = MenuDAL.Instance.GetListMenu(this.billID);

            foreach (DTO.Menu menu in listMenu)
            {
                BillItem billItem = new BillItem(menu.IdDrink, menu.DrinkName, menu.Price, menu.Count);

                billItem.onValueChanged += BillItem_onValueChanged;
                billItem.onDel += BillItem_onDel;

                billItem.Tag = menu;

                this.flowLayoutPanelBill.Controls.Add(billItem);
            }
        }

        public void LoadDrink()
        {
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
            double space = this.flowLayoutPanelDrinks.Width / 5;
            foreach (Control item in flowLayoutPanelDrinks.Controls)
            {
                item.Width = (int)space;
                item.Height = (int)(space / 3 * 4);
            }
            this.pnSearch.Location = new Point(this.pnCenter.Location.X - this.pnSearch.Width, this.pnSearch.Location.Y);
        }
        #endregion

        #region Events
        private void DrinkItem_onChoose(object sender, EventArgs e)
        {
            try
            {
                int idStaff = StaffDAL.Instance.GetStaffIDbyUsername(this.Username);
                int idDrink = ((sender as DrinkItem).Tag as Drink).ID;
                int count = 1;

                if (!BillDAL.Instance.ExistBillbyIDBill(billID))
                    BillDAL.Instance.InsertBill(billID, idStaff);

                BillInfoDAL.Instance.InsertBillInfo(billID, idDrink, count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            finally
            {
                this.flowLayoutPanelBill.Controls.Clear();
                this.lbCount.Text = MenuDAL.Instance.GetCount(billID).ToString();
                this.lbTotalPrice.Text = string.Format("{0:n0}", MenuDAL.Instance.GetTotalPrice(billID)).ToString();
                LoadBill();
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
                LoadBill();
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

                fInvoice invoice = new fInvoice(this.Username, billID, totalPrice, staffID);
                invoice.ShowDialog();

                if (BillDAL.Instance.GetStatusbyIDBill(billID) == true)
                {
                    this.lbCount.Text = "0";
                    this.lbTotalPrice.Text = "0";
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

            this.flowLayoutPanelDrinks.Controls.Clear();
            LoadDrink();
        }

        private void LbCategory_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.flowLayoutPanelCategory.Controls)
            {
                control.ForeColor = Color.Black;
            }
            ((sender as Label).Tag as Label).ForeColor = Color.FromArgb(0, 144, 218);

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
        #endregion


    }
}
