using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Category> GetListCategory()
        {
            List<Category> categories = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CATEGORY");

            foreach (DataRow row in data.Rows)
            {
                Category category = new Category(row);
                categories.Add(category);
            }

            return categories;
        }

        public void EditCategory(string name)
        {

        }

        public void AddCategory(string name)
        {
            DataProvider.Instance.ExecuteNonQuery("insert into Category values ( N'" + name + "')");
        }

        public void DeleteCategory(string name)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM CATEGORY WHERE NAME = '{0}'", name));
        }
    }
}
