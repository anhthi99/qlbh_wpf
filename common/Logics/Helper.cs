using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace common.Logics
{
    public class Helper
    {

        public Helper()
        {

        }
        /// <summary>
        /// Hàm sử dụng mã hoá MD5
        /// </summary>
        /// <param name="plain"></param>
        /// <returns></returns>
        public static string ConvertToMD5(string plain)
        {
            StringBuilder str = new StringBuilder();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bPlain = Encoding.ASCII.GetBytes(plain);
            byte [] hashed = md5.ComputeHash(bPlain);
            foreach(byte h in hashed)
            {
                str.Append(h.ToString("x2"));
            }
            return str.ToString();
        }
    }
}
