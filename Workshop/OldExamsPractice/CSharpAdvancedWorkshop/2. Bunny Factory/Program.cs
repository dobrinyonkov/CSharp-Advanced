//solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BunnyFactory2
{
    class Program
    {
        static void Main()
        {
            var cages = new List<int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                cages.Add(int.Parse(line));
            }

            for (int i = 1; ; i++)
            {
                if (i >= cages.Count)
                {
                    break;
                }
                int cagesCount = (int)SumOfIntInRange(cages, 0, i - 1);

                if (cagesCount >= cages.Count)
                {
                    break;
                }
                BigInteger sum = SumOfIntInRange(cages, i, cagesCount + i - 1);
                BigInteger product = ProductOfIntInRange(cages, i, cagesCount + i - 1);

                string result = sum.ToString() + product.ToString();
                StringBuilder newCages = new StringBuilder();
                newCages.Append(result);
                for (int j = cagesCount + i; j < cages.Count; j++)
                {
                    newCages.Append(cages[j].ToString());
                }
                cages.Clear();
                for (int j = 0; j < newCages.Length; j++)
                {
                    if (newCages[j] == '0' || newCages[j] == '1')
                    {
                        continue;
                    }
                    cages.Add(newCages[j] - '0');
                }
            }
            for (int i = 0; i < cages.Count; i++)
            {
                Console.Write("{0} ", cages[i]);
            }
            Console.WriteLine();
        }

        private static BigInteger ProductOfIntInRange(List<int> cages, int startIndex, int endIndex)
        {
            BigInteger product = 1;
            for (int i = startIndex; i <= endIndex; i++)
            {
                product *= cages[i];
            }
            return product;
        }

        private static BigInteger SumOfIntInRange(List<int> cages, int startIndex, int endIndex)
        {
            BigInteger sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += cages[i];
            }
            return sum;
        }
    }
}
