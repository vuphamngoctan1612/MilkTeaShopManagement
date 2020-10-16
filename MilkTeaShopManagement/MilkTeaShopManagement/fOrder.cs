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

                //custom button
                btn.BackColor = Color.SkyBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Calibri", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                flpDrink.Controls.Add(btn);
            }
        }
    }
}
