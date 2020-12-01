using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Staff
    {
        private int iD;
        private string name;
        private byte[] image;
        private DateTime birthDate;
        private string position;
        private string userName;
        private int overTime;
        private int fault;
        private int salaryReceived;
        private string phoneNumber;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Position { get => position; set => position = value; }
        public string UserName { get => userName; set => userName = value; }
        public int OverTime { get => overTime; set => overTime = value; }
        public byte[] Image { get => image; set => image = value; }
        public int SalaryReceived { get => salaryReceived; set => salaryReceived = value; }
        public int Fault { get => fault; set => fault = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Staff(int id, string name, byte[] image, DateTime birthdate, string position, string username, int overtime, int salaryreceived, int fault, string phonenumber)
        {
            this.iD = id;
            this.name = name;
            this.image = image;
            this.birthDate = birthdate;
            this.position = position;
            this.userName = username;
            this.overTime = overtime;
            this.salaryReceived = salaryreceived;
            this.fault = fault;
            this.phoneNumber = phonenumber;

        }

        public Staff(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.birthDate = (DateTime)row["BirthDate"];
            this.position = row["Position"].ToString();
            this.userName = row["UserName"].ToString();
            this.overTime = int.Parse(row["OverTime"].ToString());
            if (!Convert.IsDBNull(row["Image"]))
                this.Image = (byte[])row["Image"];
            this.fault = (int)row["Fault"];
            this.phoneNumber = row["PhoneNumber"].ToString();
        }
    }
}
