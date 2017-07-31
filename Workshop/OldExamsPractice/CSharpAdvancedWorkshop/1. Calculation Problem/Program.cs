//solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Calculation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string alphabet = "abcdefghijklmnopqrstuvwx";

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                int result = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    int index = alphabet.IndexOf(word[j]);
                    result += index * (int)Math.Pow(23, word.Length - 1 - j);
                }
                sum += result;

            }
            int finafinal = sum;
            var list = new List<int>();
            while (sum > 0)
            {
                list.Add(sum % 23);
                sum /= 23;
            }
            string final = "";
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (list[i] == j)
                    {
                        final += alphabet[j];
                    }
                }
            }
            Console.WriteLine("{0} = {1}", Reverse(final), finafinal);
        }
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
