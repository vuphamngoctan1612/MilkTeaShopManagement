using MilkTeaShopManagement.DAO;
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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();

            LoadDrink();
        }

        DataTable table = new DataTable();
        int rowIndex;

        void LoadDrink()
        {
            string query = "SELECT * FROM Drinks";
            table = DataProvider.Instance.ExcuteQuery(query);
            this.dtgvDrinks.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text;
            string name = this.txtName.Text;
            string price = this.txtPrice.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Vui lòng nhập thông tin đồ uống cần thêm!", "Error");
                return;
            }
            try
            {
                table.Rows.Add(id, name, price);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giá không hợp lệ, vui lòng nhập lại!", "Error");
            }
            finally
            {
                string query = "INSERT INTO Drinks VALUES('" + id + "', '" + name + "', '" + price + "')";
                DataProvider.Instance.ExecuteNonQuery(query);

                this.txtID.Clear();
                this.txtName.Clear();
                this.txtPrice.Clear();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                rowIndex = this.dtgvDrinks.CurrentCell.RowIndex;

                DataGridViewRow row = this.dtgvDrinks.Rows[rowIndex];
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                string price = row.Cells[2].Value.ToString();

                string query = "DELETE FROM Drinks WHERE ID = '" + id + "' AND Name = N'" + name + "' AND Price = " + price;
                DataProvider.Instance.ExecuteNonQuery(query);

                this.dtgvDrinks.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.txtID.Clear();
                this.txtName.Clear();
                this.txtPrice.Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dtgvDrinks.Rows[rowIndex];

            row.Cells[0].Value = this.txtID.Text;
            row.Cells[1].Value = this.txtName.Text;
            row.Cells[2].Value = this.txtPrice.Text;            
        }

        private void dtgvDrinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dtgvDrinks.Rows[rowIndex];

            this.txtID.Text = row.Cells[0].Value.ToString();
            this.txtName.Text = row.Cells[1].Value.ToString();
            this.txtPrice.Text = row.Cells[2].Value.ToString();
        }
    }
}
