//solved 75/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char opp = char.Parse(Console.ReadLine());
            string n = (Console.ReadLine());

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            BigInteger number = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int index = alphabet.IndexOf(text[i]);
                number += index * Power(26, text.Length - i - 1);
            }
            BigInteger secondNumber = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int buff = n[n.Length - 1 - i] - '0';
                secondNumber += buff * Power(7, i);
            }
            BigInteger finalResultInDec = number;
            switch (opp)
            {
                case '+': finalResultInDec += secondNumber; break;
                case '-': finalResultInDec -= secondNumber; break;
            }

            string finalresult = "";
            while (finalResultInDec > 0)
            {
                BigInteger temp = finalResultInDec % 9;
                finalresult += temp;
                finalResultInDec /= 9;
            }
            string finalfinalresult = Reverse(finalresult);
            Console.WriteLine(finalfinalresult);

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

        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
