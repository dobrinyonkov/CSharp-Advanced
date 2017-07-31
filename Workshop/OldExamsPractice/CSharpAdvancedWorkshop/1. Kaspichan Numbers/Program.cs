//solved 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong n = ulong.Parse(Console.ReadLine());


            string length = n.ToString();
            string[] kaspichanNumbers = KaspichanNumeralSystem();
            if (n == 0)
            {
                Console.WriteLine(kaspichanNumbers[n]);
                return;
            }

            ulong result = 0;
            string finalresult = string.Empty;
            var list = new List<ulong>();
            while (n > 0)
            {
                result = n % 256;
                n /= 256;
                list.Add(result);
            }

            for (int i = 0; i < list.Count; i++)
            {
                ulong index = list[list.Count - 1 - i];
                Console.Write(kaspichanNumbers[index]);
            }
            Console.WriteLine();

        }
        static void Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse);
        }
        static string[] KaspichanNumeralSystem()
        {
            string[] kaspichanDigits = new string[256];

            for (int i = 0; i < 256; i++)
            {
                if (i < 26)
                {
                    kaspichanDigits[i] = ((char)('A' + i)).ToString();
                }

                else if (i < 2 * 26)
                {
                    kaspichanDigits[i] = "a" + kaspichanDigits[i - 26];
                }

                else if (i < 3 * 26)
                {
                    kaspichanDigits[i] = "b" + kaspichanDigits[i - 2 * 26];
                }

                else if (i < 4 * 26)
                {
                    kaspichanDigits[i] = "c" + kaspichanDigits[i - 3 * 26];
                }

                else if (i < 5 * 26)
                {
                    kaspichanDigits[i] = "d" + kaspichanDigits[i - 4 * 26];
                }

                else if (i < 6 * 26)
                {
                    kaspichanDigits[i] = "e" + kaspichanDigits[i - 5 * 26];
                }
                else if (i < 7 * 26)
                {
                    kaspichanDigits[i] = "f" + kaspichanDigits[i - 6 * 26];
                }
                else if (i < 8 * 26)
                {
                    kaspichanDigits[i] = "g" + kaspichanDigits[i - 7 * 26];
                }
                else if (i < 9 * 26)
                {
                    kaspichanDigits[i] = "h" + kaspichanDigits[i - 8 * 26];
                }
                else if (i < 10 * 26)
                {
                    kaspichanDigits[i] = "i" + kaspichanDigits[i - 9 * 26];
                }
            }
            return kaspichanDigits;
        }
    }
}
