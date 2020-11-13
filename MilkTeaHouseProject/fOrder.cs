using MilkTeaHouseProject.DAL;
using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                //item.Tag = item;

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
            int idBillInfo = BillInfoDAL.Instance.GetMAXIDBillInfo() + 1;
            int idBill = BillDAL.Instance.GetMAXIDBill();
            int idDrink = ((sender as DrinkItem).Tag as Drink).ID;
            int count = 1;
            try
            {
                BillInfoDAL.Instance.InsertBillInfo(idBillInfo, idBill, idDrink, count);
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


        #endregion
    }
}
