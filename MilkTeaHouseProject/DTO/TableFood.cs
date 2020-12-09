using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class TableFood
    {
        private int iD;
        private string name;
        private bool status;
        private string nameGroup;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public bool Status { get => status; set => status = value; }
        public string NameGroup { get => nameGroup; set => nameGroup = value; }

        public TableFood(int id, string name, bool status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public TableFood (DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Status = (bool)row["Status"];
            this.nameGroup = row["NameGroup"].ToString();
        }
    }
}
