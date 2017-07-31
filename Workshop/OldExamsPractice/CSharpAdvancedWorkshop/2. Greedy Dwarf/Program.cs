//solved 30/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Greedy_Dwarf
{
    class Program
    {
        static void Main()
        {
            var valley = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int m = int.Parse(Console.ReadLine());

            int[][] patterns = new int[m][];

            for (int i = 0; i < m; i++)
            {
                patterns[i] = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            }
            BigInteger sum = 0;
            BigInteger sumMAx = long.MinValue;
            long position = 0;

            for (int i = 0; i < m; i++)
            {
                position = 0;
                BigInteger[] tempValley = FillTempValley(valley);
                for (int j = 0; ;)
                {

                    if (position >= valley.Length || tempValley[position] == 1001 || position < 0)
                    {
                        break;
                    }
                    if (j == patterns[i].Length)
                    {
                        j = -1;
                    }
                    sum += tempValley[position];
                    tempValley[position] = 1001;
                    position += patterns[i][j];
                    j++;
                    if (j >= patterns[i].Length) j = 0;
                }
                if (sum > sumMAx)
                {
                    sumMAx = sum;
                }
                sum = 0;
            }

            Console.WriteLine(sumMAx);
        }
        static BigInteger[] FillTempValley(int[] valley)
        {
            BigInteger[] tempValley = new BigInteger[valley.Length];
            for (int k = 0; k < valley.Length; k++)
            {
                tempValley[k] = valley[k];
            }
            return tempValley;
        }
    }
}
