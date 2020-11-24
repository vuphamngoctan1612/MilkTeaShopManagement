﻿using MilkTeaHouseProject.DTO;
using MilkTeaShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance 
        {
            get { if (instance == null) instance = new BillInfoDAL(); return BillInfoDAL.instance; }
            set => instance = value; 
        }

        private BillInfoDAL() { }

        public List<BillInfo> GetListBillInfoByIDBill(int idBill)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE BillID = " + idBill);

            foreach (DataRow item in data.Rows)
            {
                BillInfo bill = new BillInfo(item);
                listBillInfo.Add(bill);
            }

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idDrink , @count", new object[] { idBill, idDrink, count });
        }

        public void UpdateBillInfo(int idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("update BillInfo set Count = " + count + " where DrinkID = '" + idDrink + "'");
        }

        public void DeleteBillInfobyIDBill(int idBill)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_DeleteBillInfo @BillID ", new object[] { idBill });
        }

        public void DeleteBillInfobyIDDrink(int iddrink)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("Delete from BillInfo where drinkid = '{0}'", iddrink));
        }

        public void SetnullDrinkIdBillInfo(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_SetnullDrinkIDinBillInfo @drinkID ",
                new object[] { id });
        }
    }
}
