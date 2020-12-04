using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    class GroupTable
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public GroupTable(string name)
        {
            this.Name = name;
        }

        public GroupTable(DataRow row)
        {
            this.Name = row["Name"].ToString();
        }
    }
}
