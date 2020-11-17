using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MilkTeaHouseProject.DTO
{
        public class MenuItemDTO
    {
        string iD;
        string name;
        int price;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public byte[] Image { get; internal set; }

        public MenuItemDTO(string id, string name, int price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        public MenuItemDTO(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.Name = row["Name"].ToString();
            this.Price = (int)row["Price"];
            if (!Convert.IsDBNull(row["Image"]))
                this.Image = (byte[])row["Image"];
        }
    }
}
