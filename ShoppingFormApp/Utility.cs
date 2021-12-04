using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFormApp
{
    public static class Utility
    {
        public static bool IsEmpty(string [] arr)
        {
            foreach(var ar in arr)
            {
                if (string.IsNullOrWhiteSpace(ar))
                {
                    return false;
                }
            }
            return true;
        }
        public static string HashMe(this string pas)
        {
            byte[] stringByte = new UTF8Encoding().GetBytes(pas);
            var hashedPas = new SHA256Managed().ComputeHash(stringByte);
            string password = new UTF8Encoding().GetString(hashedPas);
            return password;
        }
    }

}
