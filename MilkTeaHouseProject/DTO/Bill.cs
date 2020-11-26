using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime checkOut;
        private bool status;
        private int total;
        private int staffID;
        private string note;

        public int ID { get => iD; set => iD = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public bool Status { get => status; set => status = value; }
        public int Total { get => total; set => total = value; }
        public int StaffID { get => staffID; set => staffID = value; }
        public string NOTE { get => note; set => note = value; }

        public Bill(int id, DateTime checkout, bool status, int staffID)
        {
            this.iD = id;
            this.CheckOut = checkout;
            this.status = status;
            this.staffID = staffID;
        }

        public Bill(DataRow row)
        {
            this.iD = (int)row["ID"];
            if (!Convert.IsDBNull(row["CHECKOUT"]))
                this.CheckOut = (DateTime)row["CHECKOUT"];
            this.status = (bool)row["status"];
            this.total = (int)row["total"];
            if (!Convert.IsDBNull(row["StaffID"]))
                this.staffID = (int)row["StaffID"];
            this.note = row["NOTE"].ToString() ;
        }
    }
}
