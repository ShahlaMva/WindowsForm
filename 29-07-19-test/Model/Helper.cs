using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _29_07_19_test.Model
{
   public static class Helper
    {
        public static string HashPaswword(string str)
        {
            byte[] passHashCode = Encoding.ASCII.GetBytes(str);
            byte[] pass = new SHA256Managed().ComputeHash(passHashCode);
            return Encoding.ASCII.GetString(pass);
        }
    }
}
