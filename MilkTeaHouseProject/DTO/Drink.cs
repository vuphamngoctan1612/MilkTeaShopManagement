using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShopManagement.DTO
{
    public class Drink
    {
        private int iD;
        private string name;
        private string Category;
        private int price;
        private byte[] image;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int ID { get => iD; set => iD = value; }
        public string CategoryID { get => Category; set => Category = value; }
        public byte[] Image { get => image; set => image = value; }

        public Drink(int id, string name, int price, string Category)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Category = Category;
        }
        public Drink(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Price = (int)row["Price"];
            this.Category = row["Category"].ToString();
            if (!Convert.IsDBNull(row["Image"]))
                this.Image = (byte[])row["Image"];
        }
    }
}
