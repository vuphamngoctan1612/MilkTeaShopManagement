using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MilkTeaHouseProject.DTO
{
    class Position
    {
        private string name;
        private int salary;
        private int overTimeSalary;
        private int minusSalary;

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public int OverTimeSalary { get => overTimeSalary; set => overTimeSalary = value; }
        public int MinusSalary { get => minusSalary; set => minusSalary = value; }

        public Position(string name, int salary, int overTimeSalary, int minusSalary)
        {
            this.name = name;
            this.salary = salary;
            this.overTimeSalary = overTimeSalary;
            this.minusSalary = minusSalary;
        }

        public Position(DataRow row)
        {
            this.name = row["Name"].ToString();
            this.salary = (int)row["Salary"];
            this.overTimeSalary = (int)row["OverTimeSalary"];
            this.minusSalary = (int)row["MinusSalary"];
        }
    }
}
