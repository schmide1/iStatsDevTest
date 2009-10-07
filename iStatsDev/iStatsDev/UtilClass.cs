using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Text;

namespace iStatsDev
{
    public class UtilClass
    {
        public static string GetPasswordHash(string strUser, string strPass)
        {
            string retVal;

            // Password hashing
            System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();

            // Salted with User ID to prevent dictionary hits
            byte[] hash = sha.ComputeHash(Encoding.Unicode.GetBytes(strPass + strUser));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            retVal = sb.ToString();

            return retVal;
        }
    }
}
