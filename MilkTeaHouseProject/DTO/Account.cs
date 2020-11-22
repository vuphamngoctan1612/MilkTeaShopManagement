using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaHouseProject.DTO
{
    public class Account
    {
        private string username;
        private string password;
        private bool type;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool Type { get => type; set => type = value; }

        public Account(string username, string password, bool type)
        {
            this.username = username;
            this.password = password;
            this.type = type;
        }

        public Account(DataRow row)
        {
            this.Username = row["USERNAME"].ToString();
            this.Password = row["PASSWORD"].ToString();
            this.type = (bool)row["TYPE"];
        }
    }
}
