//solved 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                var numsAsText = line.Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(numsAsText[col]);
                }
            }

            bool[,] pattern = new bool[,]
            {
                { true, true, true, false, false },
                { false, false, true, false, false },
                { false, false, true, true, true },
            };

            long maxSum = int.MinValue;
            bool thereIsIncreasingPattern = false;
            for (int pattternStartX = 0; pattternStartX <= matrix.GetLength(0) - pattern.GetLength(0); pattternStartX++)
            {
                for (int patternStartY = 0; patternStartY <= matrix.GetLength(1) - pattern.GetLength(1); patternStartY++)
                {
                    var numbersInPattern = new List<int>();
                    for (int patternX = 0; patternX < pattern.GetLength(0); patternX++)
                    {
                        for (int patternY = 0; patternY < pattern.GetLength(1); patternY++)
                        {
                            int x = pattternStartX + patternX;
                            int y = patternStartY + patternY;

                            if (pattern[patternX, patternY])
                            {
                                numbersInPattern.Add(matrix[x, y]);
                            }
                        }
                    }
                    bool isIncreasing = true;
                    for (int i = 1; i < numbersInPattern.Count; i++)
                    {
                        if (numbersInPattern[i - 1] != numbersInPattern[i] - 1)
                        {
                            isIncreasing = false;
                            break;
                        }
                    }
                    long sum = 0;
                    if (isIncreasing)
                    {
                        thereIsIncreasingPattern = true;
                        for (int i = 0; i < numbersInPattern.Count; i++)
                        {
                            sum += numbersInPattern[i];
                        }
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
            if (thereIsIncreasingPattern)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
                long sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, i];
                }
                Console.WriteLine("NO {0}", sum);
            }

        }
    }
}
