using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaHouseProject.DTO;
using MilkTeaHouseProject.DAL;
using MilkTeaShopManagement.DAL;

namespace MilkTeaHouseProject   
{
    public partial class fMenu : Form
    {

        public fMenu()
        {
            InitializeComponent();
            LoadMenu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddDrink f = new fAddDrink();
            f.ShowDialog();
            LoadMenu();
        }


        public void LoadMenu()
        {
            flowLayoutPanelMenu.Controls.Clear();
            List<MenuItemDTO> drinks = menuItemDAL.Instance.LoadDrinks();

            foreach (MenuItemDTO drink in drinks)
            {
                MenuItem item = new MenuItem(drink.ID, drink.Name, drink.Price, drink.Image);
                item.onDel += Item_onDel;
                item.onEdit += Item_onEdit;

                item.Tag = drink;

                flowLayoutPanelMenu.Controls.Add(item);
            }
            if (flowLayoutPanelMenu.Controls.Count == 0)
            {
                Label newlb = new Label();
                newlb.BringToFront();
                newlb.Margin = new Padding(100);
                newlb.Width = 1000;
                flowLayoutPanelMenu.Controls.Add(newlb);

                Label lb = new Label();
                lb.Width = 600;
                lb.Height = 50;
                lb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Visible = true;
                lb.ForeColor = Color.FromArgb(227, 54, 24);
                lb.BringToFront();
                lb.RightToLeft = RightToLeft.Yes;
                lb.Text = "!!!MENU RỖNG";
                flowLayoutPanelMenu.Controls.Add(lb);
            }
        }

        private void Item_onEdit(object sender, EventArgs e)
        {
            fEditDrink frm = new fEditDrink(((sender as MenuItem).Tag as MenuItemDTO).ID);
            frm.ShowDialog();
            LoadMenu();
        }

        private void Item_onDel(object sender, EventArgs e)
        {
            DeleteMenu(((sender as MenuItem).Tag as MenuItemDTO).ID);
            LoadMenu();
        }

        void DeleteMenu(string id)
        {
            string query = "DELETE FROM Drinks WHERE ID = '"+ id +"'";
            int data = DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
