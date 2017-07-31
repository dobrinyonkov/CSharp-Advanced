//solved 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tres4nums
{
    class Program
    {
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            string result = "";
            if (num == 0)
            {
                Console.WriteLine("LON+");
                return;
            }
            while (num > 0)
            {
                result += num % 9;
                num /= 9;
            }

            result = Reverse(result);

            StringBuilder finalresult = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                switch (result[i])
                {
                    case '0': finalresult.Append("LON+"); break;
                    case '1': finalresult.Append("VK-"); break;
                    case '2': finalresult.Append("*ACAD"); break;
                    case '3': finalresult.Append("^MIM"); break;
                    case '4': finalresult.Append("ERIK|"); break;
                    case '5': finalresult.Append("SEY&"); break;
                    case '6': finalresult.Append("EMY>>"); break;
                    case '7': finalresult.Append("/TEL"); break;
                    case '8': finalresult.Append("<<DON"); break;
                }
            }
            Console.WriteLine(finalresult);
        }
    }
}
