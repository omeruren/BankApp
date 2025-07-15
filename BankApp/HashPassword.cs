using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class HashPassword
    {
        public static string SHAHash(string password)
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sHA256.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
           
            foreach (byte item in hash)
            {
                sb.Append(item.ToString("x2"));
                
            }
            return sb.ToString();
        }
    }
}
