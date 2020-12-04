using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Report
    {
        public int Month { get; set; }  
        public int Year { get; set; }   
        public int Revenue { get; set; }
        public int Expense { get; set; }

        public Report(int mm, int yy, int ic, int oc)
        {
            this.Month = mm;
            this.Year = yy;
            this.Revenue = ic;
            this.Expense = oc;
        }
    }
}
