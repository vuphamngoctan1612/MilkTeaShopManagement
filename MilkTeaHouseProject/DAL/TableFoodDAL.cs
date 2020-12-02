using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DAL
{
    public class TableFoodDAL
    {
        private static TableFoodDAL instance;

        public static TableFoodDAL Instance
        {
            get { if (instance == null) instance = new TableFoodDAL(); return instance; }
            private set => instance = value; 
        }

        private TableFoodDAL() { }


    }
}
