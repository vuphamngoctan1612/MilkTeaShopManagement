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
        private int id;
        private int idStaff;
        private DateTime? checkIn;
        private DateTime checkOut;
        private int status;

        public int Id { get => id; set => id = value; }
        public int IdStaff { get => idStaff; set => idStaff = value; }
        public DateTime? CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public int Status { get => status; set => status = value; }

        public Bill(int id, int idStaff, DateTime? checkin, DateTime checkout, int status)
        {
            this.id = id;
            this.idStaff = idStaff;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.status = status;
        }

        public Bill(DataRow row)
        {
            this.id = (int)row["ID"];
            this.idStaff = (int)row["StaffID"];
            this.checkIn = (DateTime)row["CheckIn"];
            this.checkOut = (DateTime)row["CheckOut"];
            this.status = (int)row["status"];
        }
    }
}
