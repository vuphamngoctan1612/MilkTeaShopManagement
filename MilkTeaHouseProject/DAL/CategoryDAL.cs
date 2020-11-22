using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DAL
{
    class CategoryDAL
    {
        private static CategoryDAL instance;

        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return CategoryDAL.instance; }
            private set { CategoryDAL.instance = value; }
        }

        private CategoryDAL() { }


        public void AddCategory(string name)
        {
            DataProvider.Instance.ExecuteNonQuery("insert into Category values ( N'" + name + "')");
        }
        public void DeleteCategory(string name)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_DeleteCategory @Category ",
                new object[] { name });
        }
    }
}
