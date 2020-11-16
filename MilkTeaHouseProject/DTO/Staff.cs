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
        private DateTime birthDate;
        private string position;
        private string userName;
        private int workingTime;
        private int salary;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Position { get => position; set => position = value; }
        public string UserName { get => userName; set => userName = value; }
        public int WorkingTime { get => workingTime; set => workingTime = value; }
        public int Salary { get => salary; set => salary = value; }
        
        public Staff(int id, string name, DateTime birthdate, string position, string username, int workingTime, int salary)
        {
            this.iD = id;
            this.name = name;
            this.birthDate = birthdate;
            this.position = position;
            this.userName = username;
            this.workingTime = workingTime;
            this.salary = salary; ;
        }

        public Staff(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.birthDate = (DateTime)row["BirthDate"];
            this.position = row["Position"].ToString();
            this.userName = row["UserName"].ToString();
            this.workingTime = int.Parse(row["WorkingTime"].ToString());
            this.salary = (int)row["Salary"];
        }
    }
}
