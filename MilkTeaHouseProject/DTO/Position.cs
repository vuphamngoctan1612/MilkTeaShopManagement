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
        private long salary;
        private long overTimeSalary;
        private long minusSalary;

        public string Name { get => name; set => name = value; }
        public long Salary { get => salary; set => salary = value; }
        public long OverTimeSalary { get => overTimeSalary; set => overTimeSalary = value; }
        public long MinusSalary { get => minusSalary; set => minusSalary = value; }

        public Position(string name, long salary, long overTimeSalary, long minusSalary)
        {
            this.name = name;
            this.salary = salary;
            this.overTimeSalary = overTimeSalary;
            this.minusSalary = minusSalary;
        }

        public Position(DataRow row)
        {
            this.name = row["Name"].ToString();
            this.salary = (long)row["Salary"];
            this.overTimeSalary = (long)row["OverTimeSalary"];
            this.minusSalary = (long)row["MinusSalary"];
        }
    }
}
