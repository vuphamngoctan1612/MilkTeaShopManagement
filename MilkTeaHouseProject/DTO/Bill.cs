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
        private DateTime? checkOut;
        private int status;
        private int total;
        private int staffID;

        public int ID { get => iD; set => iD = value; }
        public DateTime? CheckOut { get => checkOut; set => checkOut = value; }
        public int Status { get => status; set => status = value; }
        public int Total { get => total; set => total = value; }
        public int StaffID { get => staffID; set => staffID = value; }

        public Bill(int id, DateTime? checkout, int status, int staffID)
        {
            this.iD = id;
            this.CheckOut = checkout;
            this.status = status;
            this.staffID = staffID;
        }

        public Bill(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.CheckOut = (DateTime?)row["CheckOut"];
            this.status = (int)row["status"];
            this.total = (int)row["total"];
            this.staffID = (int)row["StaffID"];
        }
    }
}
