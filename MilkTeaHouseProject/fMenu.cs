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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddDrink f = new fAddDrink();
            f.ShowDialog();
            LoadMenu();
            flowLayoutPanelMenu_SizeChanged(sender, e);
        }

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

                MenuItem item = new MenuItem(drink.ID, drink.Name, drink.Price,drink.CategoryID, drink.Image, setcolor);
                item.onDel += Item_onDel;
                item.onEdit += Item_onEdit;

                item.Tag = drink;

                flowLayoutPanelMenu.Controls.Add(item);
            }
            if (flowLayoutPanelMenu.Controls.Count == 0)
            {
                Panel pn = new Panel();
                pn.Width=flowLayoutPanelMenu.Width-14;
                pn.Height = flowLayoutPanelMenu.Height - 10;
                this.flowLayoutPanelMenu.Controls.Add(pn);
                Label lb = new Label();
                lb.Width = 600;
                lb.Height = 50;
                lb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Visible = true;
                lb.ForeColor = Color.FromArgb(227, 54, 24);
                lb.Location = new Point(this.flowLayoutPanelMenu.Width/2,this.flowLayoutPanelMenu.Height/2);
                lb.Text = "MENU RỖNG!!!";
                pn.Controls.Add(lb);
            }
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

        void DeleteMenu(int id)
        {
            DrinkDAL.Instance.DelDrink(id);
        }

        private void flowLayoutPanelMenu_SizeChanged(object sender, EventArgs e)
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
    }
}
