//solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EvenDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] diffs = new long[numbers.Length - 1];
            BigInteger sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                diffs[i] = Math.Max(numbers[i], numbers[i + 1]) - Math.Min(numbers[i], numbers[i + 1]);
            }

            int evenejump = 1;
            for (int step = 0; step < diffs.Length; step++)
            {
                if (diffs[step] % 2 == 0)
                {
                    sum += diffs[step];
                    step += evenejump;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
