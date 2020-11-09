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

        public void LoadBill()
        {
            List<DTO.Menu> listMenu = MenuDAL.Instance.GetListMenu();

            foreach (DTO.Menu menu in listMenu)
            {
                BillItem item = new BillItem(menu.DrinkName, menu.Price, menu.Count);
                this.flowLayoutPanelBill.Controls.Add(item);
            }
        }

        public void LoadDrink()
        {
            List<Drink> drinks = DrinkDAL.Instance.LoadDrinks();

            foreach (Drink drink in drinks)
            {
                DrinkItem item = new DrinkItem(drink.Name, drink.Price);
                item.Tag = drink;
                
                item.onChoose += Item_onChoose;

                flowLayoutPanelDrinks.Controls.Add(item);
            }
        }

        private void Item_onChoose(object sender, EventArgs e)
        {
            BillItem item = new BillItem(((sender as DrinkItem).Tag as Drink).Name, ((sender as DrinkItem).Tag as Drink).Price);

            this.flowLayoutPanelBill.Controls.Add(item);

            this.flowLayoutPanelBill.Tag = (sender as DrinkItem).Tag;
        }
    }
}
