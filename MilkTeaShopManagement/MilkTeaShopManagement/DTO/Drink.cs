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
        string iD;
        string name;
        int price;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public Drink(string id, string name, int price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        public Drink(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.Name = row["Name"].ToString();
            this.Price = (int)row["Price"];
        }
    }
}
