using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlueTeamProject
{
    internal class HashClass
    {
        public static string GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();
            byte[] hashes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hashes) stringBuilder.Append(b.ToString("X2"));
            return stringBuilder.ToString();
        }
    }
}
