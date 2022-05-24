using System;
using System.Linq;

namespace webPostgres.Helpers
{
    public class Security
    {
        public static string CodePassword(string passwordText)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(passwordText);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string DecodePassword(string passwordCode)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(passwordCode);
            System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
