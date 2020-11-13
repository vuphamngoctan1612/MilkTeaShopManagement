using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Menu
    {
        private string idDrink;
        private string drinkName;
        private int price;
        private int count;

        public string DrinkName { get => drinkName; set => drinkName = value; }
        public int Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public string IdDrink { get => idDrink; set => idDrink = value; }

        public Menu(string drinkName, int price, int count)
        {
            this.drinkName = drinkName;
            this.price = price;
            this.count = count; 
        }

        public Menu(DataRow row)
        {
            this.idDrink = row["ID"].ToString();    
            this.drinkName = row["Name"].ToString();
            this.price = (int)row["Price"];
            this.count = (int)row["Count"];
        }
    }
}
