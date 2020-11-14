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
        public fOrder()
        {
            InitializeComponent();

            LoadDrink();
        }

        #region Methods
        public void LoadBill()
        {
            List<DTO.Menu> listMenu = MenuDAL.Instance.GetListMenu(BillDAL.Instance.GetMAXIDBill());

            foreach (DTO.Menu menu in listMenu)
            {
                BillItem item = new BillItem(menu.IdDrink, menu.DrinkName, menu.Price, menu.Count);

                item.onValueChanged += Item_onValueChanged;

                this.flowLayoutPanelBill.Controls.Add(item);
            }
        }

        public void LoadDrink()
        {
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();

            foreach (Drink drink in drinks)
            {
                DrinkItem item = new DrinkItem(drink.Name, drink.Price);
                item.Tag = drink;

                item.onChoose += Item_onChoose;

                this.flowLayoutPanelDrinks.Controls.Add(item);
            }
        }
        #endregion

        #region Events
        private void Item_onChoose(object sender, EventArgs e)
        {
            try
            {
                int idBill = BillDAL.Instance.GetMAXIDBill();
                int idBillInfo = BillInfoDAL.Instance.GetMAXIDBillInfo() + 1;
                int idDrink = ((sender as DrinkItem).Tag as Drink).ID;
                int count = 1;

                if (!BillDAL.Instance.existBill())
                {
                    BillDAL.Instance.InsertBill(idBill);
                }

                BillInfoDAL.Instance.InsertBillInfo(idBillInfo, idBill, idDrink, count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.flowLayoutPanelBill.Controls.Clear();
                this.lbCount.Text = MenuDAL.Instance.GetCount().ToString();
                this.lbTotalPrice.Text = MenuDAL.Instance.GetTotalPrice().ToString() + " VNĐ";
                LoadBill();
            }
        }

        private void Item_onValueChanged(object sender, EventArgs e)
        {
            this.lbCount.Text = MenuDAL.Instance.GetCount().ToString();
            this.lbTotalPrice.Text = MenuDAL.Instance.GetTotalPrice().ToString() + " VNĐ";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int idBill = BillDAL.Instance.GetMAXIDBill();
                DateTime checkout = DateTime.Now;
                bool status = true;
                int total = MenuDAL.Instance.GetTotalPrice();

                BillDAL.Instance.UpdateBill(idBill, checkout, status, total);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.flowLayoutPanelBill.Controls.Clear();
                this.lbCount.Text = "0";
                this.lbTotalPrice.Text = "0 VNĐ";

                BillDAL.Instance.InsertBill(BillDAL.Instance.GetMAXIDBill() + 1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelBill.Controls.Clear();
            this.lbCount.Text = "0";
            this.lbTotalPrice.Text = "0 VNĐ";

            int BillID = BillDAL.Instance.GetMAXIDBill();
            BillInfoDAL.Instance.DeleteBillInfo(BillID);
            BillDAL.Instance.DeleteBill(BillID);
        }

        #endregion
    }
}
