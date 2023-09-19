using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public static class MyEncryption
    {

        static Random random = new Random();

        public static byte[] Encrypt(string str)
        {
            return SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
        }

        public static string EncryptToString(string str)
        {
            var builder = new StringBuilder();
            foreach (byte b in Encrypt(str))
                builder.Append(b.ToString());
            return builder.ToString();
        }

        static string CreateSalt()
        {
            string salt = "";
            for (int i = 0; i < 10; i++)
            {
                salt += (char)(random.Next(0, 127));
            }
            return salt;
        }

        public static string AddSalt(String str)
        {
            string salt = CreateSalt();
            return salt + str;
        }

        public static string RemoveSalt(String str)
        {
            return str.Remove(0, 10);
        }
    }
}