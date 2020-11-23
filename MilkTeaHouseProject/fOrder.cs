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
                item.onChoose += Item_onChoose;

                this.flowLayoutPanelDrinks.Controls.Add(item);
            }
        }

        public void LoadBill()
        {
            List<DTO.Menu> listMenu = MenuDAL.Instance.GetListMenu(BillDAL.Instance.GetMAXIDBill());

            foreach (DTO.Menu menu in listMenu)
            {
                BillItem item = new BillItem(menu.IdDrink, menu.DrinkName, menu.Price, menu.Count);

                item.onValueChanged += Item_onValueChanged;
                item.onDel += Item_onDel;

                item.Tag = menu;
                
                this.flowLayoutPanelBill.Controls.Add(item);
            }
        }

        public void LoadDrink()
        {
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();

            foreach (Drink drink in drinks)
            {
                DrinkItem item = new DrinkItem(drink.Name, drink.Price,drink.Image);
                item.Tag = drink;
                item.onChoose += Item_onChoose;

                this.flowLayoutPanelDrinks.Controls.Add(item);
            }
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
                    item.onChoose += Item_onChoose;

                    this.flowLayoutPanelDrinks.Controls.Add(item);
                }
            }
        }
        #endregion

        #region Events
        private void Item_onChoose(object sender, EventArgs e)
        {
            try
            {
                int idBill = BillDAL.Instance.GetMAXIDBill();
                int idStaff = StaffDAL.Instance.GetStaffID(this.Username);
                int idDrink = ((sender as DrinkItem).Tag as Drink).ID;
                int count = 1;

                if (!BillDAL.Instance.existBill())
                {
                    BillDAL.Instance.InsertBill(idBill, idStaff);
                }

                BillInfoDAL.Instance.InsertBillInfo(idBill, idDrink, count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "1");
            }
            finally
            {
                this.flowLayoutPanelBill.Controls.Clear();
                this.lbCountTotal.Text = MenuDAL.Instance.GetCount().ToString();
                this.lbTotalPrice.Text = MenuDAL.Instance.GetTotalPrice().ToString();
                LoadBill();
            }
        }

        private void Item_onDel(object sender, EventArgs e)
        {
            try
            {
                int drinkID = ((sender as BillItem).Tag as DTO.Menu).IdDrink;

                BillInfoDAL.Instance.DeleteBillInfobyIDDrink(drinkID);
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

        private void Item_onValueChanged(object sender, EventArgs e)
        {
            this.lbCountTotal.Text = MenuDAL.Instance.GetCount().ToString();
            this.lbTotalPrice.Text = MenuDAL.Instance.GetTotalPrice().ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanelBill.Controls.Count != 0)
            {
                int idBill = BillDAL.Instance.GetMAXIDBill();
                int idStaff = StaffDAL.Instance.GetStaffID(this.Username);
                DateTime checkout = DateTime.Now;
                bool status = true;
                int total = MenuDAL.Instance.GetTotalPrice();
                try
                {
                    BillDAL.Instance.UpdateBill(idBill, checkout, status, total, idStaff);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    this.flowLayoutPanelBill.Controls.Clear();
                    this.lbCountTotal.Text = "0";
                    this.lbTotalPrice.Text = "0";

                    BillDAL.Instance.InsertBill(BillDAL.Instance.GetMAXIDBill() + 1, idStaff);
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
                    int BillID = BillDAL.Instance.GetMAXIDBill();
                    BillInfoDAL.Instance.DeleteBillInfobyIDBill(BillID);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    this.flowLayoutPanelBill.Controls.Clear();
                    this.lbCountTotal.Text = "0";
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
            double space = this.flowLayoutPanelDrinks.Width / 5;
            foreach (Control item in flowLayoutPanelDrinks.Controls)
            {
                item.Width =(int) space;
            }
            this.pnSearch.Location = new Point(this.pnCenter.Location.X-300,this.pnSearch.Location.Y);
            double SearchWidth = this.flowLayoutPanelDrinks.Width / 3.3;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void lbAll_Click(object sender, EventArgs e)
        {
            this.lbAll.ForeColor = Color.FromArgb(0, 144, 218);

            this.flowLayoutPanelDrinks.Controls.Clear();
            LoadDrink();
        }

        private void LbCategory_Click(object sender, EventArgs e)
        {
            ((sender as Label).Tag as Label).ForeColor = Color.FromArgb(0, 144, 218);

            this.flowLayoutPanelDrinks.Controls.Clear();
            LoadDrinkbyCategory(((sender as Label).Tag as Label).Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDrink(this.txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDrink(txtSearch.Text);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.btnSearch_Click(sender, e);
            }
        }
        #endregion
    }
}
