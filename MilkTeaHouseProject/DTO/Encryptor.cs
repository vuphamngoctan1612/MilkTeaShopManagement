using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShopManagement
{
    public class Encryptor
    {
        private static Encryptor instance;

        public static Encryptor Instance {
            get { if (instance == null) instance = new Encryptor(); return Encryptor.instance; }
            private set { Encryptor.instance = value; }
        }

        private Encryptor() { }

        public string Encrypt(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
