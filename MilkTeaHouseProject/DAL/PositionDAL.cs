﻿using MilkTeaHouseProject.DTO;
using MilkTeaHouseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MilkTeaShopManagement.DAL;
using System.IO;

namespace MilkTeaHouseProject.DAL
{
    class PositionDAL
    {
        private static PositionDAL instance;

        public static PositionDAL Instance
        {
            get { if (instance == null) instance = new PositionDAL(); return instance; }
        }

        private PositionDAL() { }

        public List<Position> GetListPosistion()
        {
            List<Position> posistions = new List<Position>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Position");

            foreach (DataRow dataRow in data.Rows)
            {
                Position position = new Position(dataRow);
                posistions.Add(position);
            }
            return posistions;
        }



        public bool UpdateSalary(string pos, int salary, int overtimesalary, int minussalary)
        {
            try
            {
                 return DataProvider.Instance.ExecuteNonQuery("USP_UpdateSalary @position , @salary , @overtimesalary , @minussalary ",
                    new object[] { pos, salary, overtimesalary, minussalary }) > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
