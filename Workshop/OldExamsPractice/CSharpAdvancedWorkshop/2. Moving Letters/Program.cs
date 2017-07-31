//solved 86/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Moving_Letters
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            int length = int.MinValue;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > length)
                {
                    length = words[i].Length;
                }
            }

            StringBuilder text = new StringBuilder();

            for (int k = 0; k < length; k++)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    for (int j = 0; j < word.Length; j++)
                    {
                        text.Append(word[word.Length - 1 - j]);
                        word = word.Remove(word.Length - 1 - j);
                        words[i] = word;
                        break;
                    }
                }
            }

            char[] array = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                int move = char.ToLower(letter) - 'a' + 1;
                int position = (i + move) % text.Length;
                text.Remove(i, 1);
                text.Insert(position, letter);
            }
            Console.WriteLine(text);
        }
    }
}
