using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using System.Windows.Controls;

namespace MilkTeaHouseProject.DTO
{
    public class Staff
    {
        string iD;
        string name;
        string birthDate;
        string position;
        string userName;
        int basicSalary;
        int workingTime;
        int salary;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Position { get => position; set => position = value; }
        public string UserName { get => userName; set => userName = value; }
        public int BasicSalary { get => basicSalary; set => basicSalary = value; }
        public int WorkingTime { get => workingTime; set => workingTime = value; }
        public int Salary { get => salary; set => salary = value; }

        public Staff(string id, string name, string birthdate, string position, string userName, int basicSalary, int workingTime, int salary)
        {
            this.ID = id;
            this.Name = name;
            this.BirthDate = birthdate;
            this.Position = position;
            this.UserName = userName;
            this.BasicSalary = basicSalary;
            this.WorkingTime = workingTime;
            this.Salary = salary;
        }
        public Staff(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.Name = row["Name"].ToString();
            this.BirthDate = row["BirthDate"].ToString().Substring(0,10);
            this.Position = row["Position"].ToString();
            this.UserName = row["UserName"].ToString();
            this.BasicSalary = int.Parse(row["BasicSalary"].ToString());
            this.WorkingTime = int.Parse(row["WorkingTime"].ToString());
            this.Salary = int.Parse(row["Salary"].ToString());
        }
    }
}
