using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTeaShopManagement.DTO;
using MilkTeaShopManagement.DAL;
using MilkTeaHouseProject.DAL;

namespace MilkTeaHouseProject
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
            LoadMenu();
        }
        #region Method
        public void LoadMenu()
        {
            flowLayoutPanelMenu.Controls.Clear();
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();
            bool setcolor = true;

            foreach (Drink drink in drinks)
            {
                if (setcolor == true)
                    setcolor = false;
                else
                    setcolor = true;

                MenuItem item = new MenuItem(drink.ID, drink.Name, drink.Price, drink.CategoryID, drink.Image, setcolor);
                item.onDel += Item_onDel;
                item.onEdit += Item_onEdit;

                item.Tag = drink;

                flowLayoutPanelMenu.Controls.Add(item);
            }
        }

        public void SearchDrink(string search)
        {
            List<Drink> drinks = DrinkDAL.Instance.LoadDrink();
            this.flowLayoutPanelMenu.Controls.Clear();
            bool setcolor = true;

            foreach (Drink drink in drinks)
            {
                string name = drink.Name;
                if (name.ToLower().Contains(this.txtSearch.Text.ToLower()))
                {
                    if (setcolor == true)
                        setcolor = false;
                    else
                        setcolor = true;
                    MenuItem item = new MenuItem(drink.ID, drink.Name, drink.Price, drink.CategoryID, drink.Image, setcolor);
                    item.Tag = drink;
                    item.onDel += Item_onDel;
                    item.onEdit += Item_onEdit;

                    this.flowLayoutPanelMenu.Controls.Add(item);
                }
            }
            LoadSize();
        }

        private void LoadSize()
        {
            foreach (Control item in flowLayoutPanelMenu.Controls)
            {
                item.Width = flowLayoutPanelMenu.Width;
            }

            double space = flowLayoutPanelMenu.Width / 6;
            lbID.Location = new Point((int)space, 8);
            lbCategory.Location = new Point((int)space * 2, 8);
            lbName.Location = new Point((int)space * 3, 8);
            lbPrice.Location = new Point((int)space * 4, 8);
        }

        void DeleteMenu(int id)
        {
            DrinkDAL.Instance.DelDrink(id);
        }
        #endregion

        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddDrink f = new fAddDrink();
            f.ShowDialog();
            LoadMenu();
            flowLayoutPanelMenu_SizeChanged(sender, e);
        }

        private void Item_onEdit(object sender, EventArgs e)
        {
            int id = ((sender as MenuItem).Tag as Drink).ID;
            string name = ((sender as MenuItem).Tag as Drink).Name;
            int price = ((sender as MenuItem).Tag as Drink).Price;
            byte[] image = ((sender as MenuItem).Tag as Drink).Image;

            fEditDrink frm = new fEditDrink(id, name, price, image);
            frm.ShowDialog();
            LoadMenu();

            flowLayoutPanelMenu_SizeChanged(sender, e);
        }

        private void Item_onDel(object sender, EventArgs e)
        {
            DeleteMenu(((sender as MenuItem).Tag as Drink).ID);
            LoadMenu();

            flowLayoutPanelMenu_SizeChanged(sender, e);
        }

        private void flowLayoutPanelMenu_SizeChanged(object sender, EventArgs e)
        {
            LoadSize();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            fCategory frm = new fCategory();
            frm.ShowDialog();
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            fDelCategory frm = new fDelCategory();
            frm.ShowDialog();
            LoadMenu();

            this.flowLayoutPanelMenu_SizeChanged(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDrink(txtSearch.Text);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDrink(txtSearch.Text);
        }
        #endregion
    }
}
