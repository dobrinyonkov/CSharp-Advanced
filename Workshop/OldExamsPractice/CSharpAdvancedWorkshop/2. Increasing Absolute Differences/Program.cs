//solved 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Absolute_Differences
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                bool isIncreasing = true;
                int[] tempNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] arrOfDiff = new int[tempNumbers.Length - 1];

                for (int j = 0; j < tempNumbers.Length - 1; j++)
                {
                    int diff = Math.Max(tempNumbers[j], tempNumbers[j + 1]) - Math.Min(tempNumbers[j], tempNumbers[j + 1]);
                    arrOfDiff[j] = diff;
                }
                for (int j = 1; j < arrOfDiff.Length; j++)
                {
                    int diff = arrOfDiff[j] - arrOfDiff[j - 1];
                    if (diff > 1)
                    {
                        isIncreasing = false;
                        break;
                    }
                    if (!(arrOfDiff[j - 1] <= arrOfDiff[j]))
                    {
                        isIncreasing = false;
                        break;
                    }
                }
                Console.WriteLine(isIncreasing);
            }
        }
    }
}
