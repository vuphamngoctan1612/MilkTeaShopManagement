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
        private string category;
        private long price;
        private byte[] image;
        private bool status;
        private int count;
        private long originPrice;

        public string Name { get => name; set => name = value; }
        public long Price { get => price; set => price = value; }
        public int ID { get => iD; set => iD = value; }
        public string Category { get => category; set => category = value; }
        public byte[] Image { get => image; set => image = value; }
        public bool Status { get => status; set => status = value; }
        public int Count { get => count; set => count = value; }
        public long OriginPrice { get => originPrice; set => originPrice = value; }

        public Drink(int id, string name, long price, string Category)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.category = Category;
        }
        public Drink(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Price = (long)row["Price"];
            this.category = row["Category"].ToString();
            if (!Convert.IsDBNull(row["Image"]))
                this.Image = (byte[])row["Image"];
            this.Status = (bool)row["STATUS"];
            this.Count = int.Parse(row["COUNT"].ToString());
            this.OriginPrice = long.Parse(row["originprice"].ToString());
        }
    }
}
