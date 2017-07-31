//solved 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _9GagNumber
{
    class Program
    {

        static string CheckNumber(string digit)
        {
            string digit1 = "NO";
            switch (digit)
            {
                case "-!": digit1 = "0"; break;
                case "**": digit1 = "1"; break;
                case "!!!": digit1 = "2"; break;
                case "&&": digit1 = "3"; break;
                case "&-": digit1 = "4"; break;
                case "!-": digit1 = "5"; break;
                case "*!!!": digit1 = "6"; break;
                case "&*!": digit1 = "7"; break;
                case "!!**!-": digit1 = "8"; break;
            }
            return digit1;
        }
        static BigInteger Power(int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 9;
            }
            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            string digit = string.Empty;
            string numberIn9th = "";

            BigInteger result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                digit += input[i].ToString();
                string newDigit = CheckNumber(digit);
                if (newDigit != "NO")
                {
                    numberIn9th += newDigit;
                    digit = "";
                }

            }
            for (int i = 0; i < numberIn9th.Length; i++)
            {
                BigInteger num = (BigInteger)numberIn9th[i] - '0';
                result += num * Power(numberIn9th.Length - 1 - i);
            }
            Console.WriteLine(result);
        }
    }
}
