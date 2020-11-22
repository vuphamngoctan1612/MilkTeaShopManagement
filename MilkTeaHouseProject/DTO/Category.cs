using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Category
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Category(string name)
        {
            this.name = name;
        }

        public Category(DataRow row)
        {
            this.name = row["NAME"].ToString();
        }
    }
}
