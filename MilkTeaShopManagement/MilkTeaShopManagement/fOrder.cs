using MilkTeaShopManagement.DAO;
using MilkTeaShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                btn.Tag = drink;

                //custom button
                btn.BackColor = Color.SkyBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Calibri", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                flpDrink.Controls.Add(btn);

                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(((sender as Button).Tag as Drink).Name);
            item.SubItems.Add("1");
            item.SubItems.Add(((sender as Button).Tag as Drink).Price.ToString());
            this.lvOrder.Items.Add(item);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Bill.txt"))
                {
                    foreach (ListViewItem item in this.lvOrder.Items)
                    {
                        writer.WriteLine(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text);
                    }
                    MessageBox.Show("Your data has been successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvOrder.Items.Count > 0)
                    this.lvOrder.Items.Remove(this.lvOrder.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chọn món cần xóa!", "Lỗi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
