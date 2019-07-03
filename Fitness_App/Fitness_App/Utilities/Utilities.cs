using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Fitness_App.Utilities
{
    public static class Hash
    {
        public static string GetHash(string password)
        {
            byte[] bytes = new ASCIIEncoding().GetBytes(password);
            byte[] encryptedBytes = new SHA256Managed().ComputeHash(bytes);
            return new ASCIIEncoding().GetString(encryptedBytes);
        }

        public static bool CheckHash(string hashedWord, string word)
        {
           
            return hashedWord == GetHash(word);
        }
    }
}
