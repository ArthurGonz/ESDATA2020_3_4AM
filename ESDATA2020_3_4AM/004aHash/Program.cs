using System;
using System.Security.Cryptography;
using System.Text;

namespace _004aHash
{
    class Program
    {
        static void Main(string[] args)
        {
            string sSourceData;
            byte[] tmpSource;
            byte[] tmpHash;

            sSourceData = "MySourceData";
            //Create a byte array from source data.
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            //Compute hash based on source data.
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            Console.WriteLine(sSourceData);
            Console.WriteLine(ByteArrayToString(tmpHash));

            sSourceData = "NotMySourceData";
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            byte[] tmpNewHash;
            tmpNewHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            Console.WriteLine(sSourceData);
            Console.WriteLine(ByteArrayToString(tmpNewHash));

            bool bEqual = false;
            if (tmpNewHash.Length == tmpHash.Length)
            {
                int i = 0;
                while ((i < tmpNewHash.Length) && (tmpNewHash[i] == tmpHash[i]))
                {
                    i += 1;
                }
                if (i == tmpNewHash.Length)
                {
                    bEqual = true;
                }
            }

            if (bEqual)
                Console.WriteLine("The two hash values are the same");
            else
                Console.WriteLine("The two hash values are not the same");
            Console.ReadLine();

        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2") + " ");
            }
            return sOutput.ToString();
        }
    }
}
