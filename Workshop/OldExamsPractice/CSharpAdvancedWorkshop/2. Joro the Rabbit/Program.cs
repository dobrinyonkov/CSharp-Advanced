//solved 95/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTheRabbit
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] Array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                Array[i] = (int.Parse(numbers[i]));
            }



            int maxCounter = 0;
            for (int startIndex = 0; startIndex < Array.Length; startIndex++)
            {
                for (int step = 1; step < Array.Length; step++)
                {
                    int index = startIndex;
                    int counter = 1;
                    int next = index + step;
                    if (next >= Array.Length)
                    {
                        next = next - Array.Length;
                    }
                    while (Array[index] < Array[next])
                    {
                        counter++;
                        index = next;
                        next = (index + step) % Array.Length;
                    }

                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                    }
                }

            }
            Console.WriteLine(maxCounter);

        }
    }
}
