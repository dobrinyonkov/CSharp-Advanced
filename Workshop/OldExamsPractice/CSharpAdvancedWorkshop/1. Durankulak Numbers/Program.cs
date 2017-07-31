//solved 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durankulak_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] durakanDigits = DurakanDigitis();
            string currentLetter = string.Empty;

            List<long> list = new List<long>();

            long sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ('z' <= input[i] || input[i] >= 'a')
                {
                    currentLetter = input.Substring(i, 2);
                    i++;

                    for (int j = 0; j < durakanDigits.Length; j++)
                    {
                        if (currentLetter == durakanDigits[j])
                        {
                            list.Add(j);

                        }
                    }
                }
                else
                {
                    currentLetter = input[i].ToString();
                    for (int j = 0; j < durakanDigits.Length; j++)
                    {
                        if (currentLetter == durakanDigits[j])
                        {
                            list.Add(j);
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)

            {
                list[i] = list[i] * (long)Math.Pow(168, list.Count - 1 - i);
                sum += list[i];
            }

            Console.WriteLine(sum);
        }

        private static string[] DurakanDigitis()
        {
            string[] durakanDigits = new string[168];

            for (int i = 0; i < 168; i++)
            {
                if (i < 26)
                {
                    durakanDigits[i] = ((char)('A' + i)).ToString();
                }

                else if (i < 2 * 26)
                {
                    durakanDigits[i] = "a" + durakanDigits[i - 26];
                }

                else if (i < 3 * 26)
                {
                    durakanDigits[i] = "b" + durakanDigits[i - 2 * 26];
                }

                else if (i < 4 * 26)
                {
                    durakanDigits[i] = "c" + durakanDigits[i - 3 * 26];
                }

                else if (i < 5 * 26)
                {
                    durakanDigits[i] = "d" + durakanDigits[i - 4 * 26];
                }

                else if (i < 6 * 26)
                {
                    durakanDigits[i] = "e" + durakanDigits[i - 5 * 26];
                }
                else
                {
                    durakanDigits[i] = "f" + durakanDigits[i - 6 * 26];
                }
            }


            return durakanDigits;
        }
    }
}
