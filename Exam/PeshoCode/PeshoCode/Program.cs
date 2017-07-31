//solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Problem
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            StringBuilder text1 = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                text1.Append(line);
            }
            string text = text1.ToString();

            BigInteger sum = 0;

            int indexOF = text.IndexOf(word);
            int beg = 0;
            int last = 0;

            for (int i = indexOF; i < text.Length; i--)
            {
                if (char.IsUpper(text[i]))
                {
                    beg = i;
                    break;
                }
            }
            for (int i = indexOF + word.Length; i < text.Length; i++)
            {
                if (text[i] == '?' || text[i] == '.')
                {
                    last = i;
                    break;
                }
            }

            text = text.Remove(last + 1);
            text = text.Substring(beg);




            string result = text;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '.')
                {
                    int indexOfWord = result.IndexOf(word);
                    result = result.Remove(indexOfWord);
                    result = result.ToUpper();
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[j] == ' ' || result[j] == '.')
                        {
                            continue;
                        }
                        sum += result[j];
                    }
                    break;
                }

                if (result[i] == '?')
                {
                    int indexOfWord = result.IndexOf(word);
                    result = result.Remove(i);
                    result = result.Substring(indexOfWord + word.Length);
                    result = result.ToUpper();
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[j] == ' ' || result[j] == '?')
                        {
                            continue;
                        }
                        sum += result[j];
                    }
                    break;
                }
            }
            Console.WriteLine(sum);

        }
        public static string Extract(string text, string word)
        {
            string result = "";
            string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            char[] separators = GetNonLetterSymbols(text);

            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(separators,
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var singleWord in words)
                {
                    if (singleWord == word)
                    {
                        result += (sentence.Trim() + ". ");
                    }
                }

            }

            return result;
        }
        private static char[] GetNonLetterSymbols(string input)
        {
            char[] symbols = input
                .Where(ch => !char.IsLetter(ch))
                .Distinct()
                .ToArray();

            return symbols;
        }
    }
}