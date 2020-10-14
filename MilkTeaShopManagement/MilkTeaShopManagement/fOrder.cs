using MilkTeaShopManagement.DAO;
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

namespace MilkTeaShopManagement
{
    public partial class fOrder : Form
    {
        public fOrder()
        {
            InitializeComponent();

            loadDrinks();
        }

        private void loadDrinks()
        {
            List<Drink> drinks = DrinkDAO.Instance.LoadDrinkList();

            foreach (Drink drink in drinks)
            {
                Button btn = new Button() { Width = DrinkDAO.DrinkWidth, Height = DrinkDAO.DrinkHeight };
                btn.Text = drink.Name + Environment.NewLine + drink.Price;

                flpDrink.Controls.Add(btn);
            }
        }
    }
}
