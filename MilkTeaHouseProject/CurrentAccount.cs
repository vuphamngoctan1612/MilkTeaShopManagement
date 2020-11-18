using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject
{
    public static class CurrentAccount
    {
        private static string userName;
        private static string passWord;
        private static bool type;

        public static string UserName { get => userName; set => userName = value; }
        public static string PassWord { get => passWord; set => passWord = value; }
        public static bool Type { get => type; set => type = value; }
    }
}
