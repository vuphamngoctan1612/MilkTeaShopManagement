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
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public Category(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.name = row["NAME"].ToString();
        }
    }
}
