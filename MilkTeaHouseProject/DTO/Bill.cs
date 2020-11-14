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
        //private int staffID;
        private DateTime? checkIn;
        private DateTime? checkOut;
        private int status;
        private int total;

        public DateTime? CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime? CheckOut { get => checkOut; set => checkOut = value; }
        public int Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }
        //public int StaffID { get => staffID; set => staffID = value; }
        public int Total { get => total; set => total = value; }

        public Bill(int id, DateTime? checkin, DateTime? checkout, int status)
        {
            this.iD = id;
            //this.staffID = idStaff;
            this.checkIn = checkin;
            this.CheckOut = checkout;
            this.status = status;
        }

        public Bill(DataRow row)
        {
            this.iD = (int)row["ID"];
            //this.staffID = (int)row["StaffID"];
            this.checkIn = (DateTime?)row["CheckIn"];
            this.CheckOut = (DateTime?)row["CheckOut"];
            this.status = (int)row["status"];
            this.total = (int)row["total"];
        }
    }
}
