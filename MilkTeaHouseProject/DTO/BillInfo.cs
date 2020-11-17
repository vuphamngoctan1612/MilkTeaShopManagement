using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class BillInfo
    {
        private int id;
        private int idBill;
        private string idDrink;
        private int count;

        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public string IdDrink { get => idDrink; set => idDrink = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(int id, int idBill, string idDrink, int count)
        {
            this.id = id;
            this.idBill = idBill;
            this.idDrink = idDrink;
            this.count = count;
        }

        public BillInfo(DataRow row)
        {
            this.id = (int)row["Id"];
            this.idBill = (int)row["BillID"];
            this.idDrink = row["DrinkID"].ToString();
            this.count = (int)row["Count"];
        }
    }
}
