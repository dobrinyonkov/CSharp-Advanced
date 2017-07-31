//Solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLandNumbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] array = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };

            string result = "";
            string tempString = "";

            for (int i = 1; input.Length > 0; i++)
            {
                tempString = input.Substring(0, i);
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempString == array[j])
                    {
                        result += j.ToString();
                        input = input.Remove(0, i);
                        i = -1;
                        tempString = "";
                    }
                }
            }

            BigInteger finalResult = 0;
            for (int i = 0; i < result.Length; i++)
            {
                finalResult += (result[i] - '0') * Power(7, result.Length - 1 - i);
            }
            Console.WriteLine(finalResult);
        }
        static BigInteger Power(int number, int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
