//solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var newText = new List<ulong>();
            for (int i = 0; i < text.Length; i += 4)
            {
                string buffer = text.Substring(i, 4);

                switch (buffer)
                {
                    case "Rawr": newText.Add(0); break;
                    case "Rrrr": newText.Add(1); break;
                    case "Hsst": newText.Add(2); break;
                    case "Ssst": newText.Add(3); break;
                    case "Grrr": newText.Add(4); break;
                    case "Rarr": newText.Add(5); break;
                    case "Mrrr": newText.Add(6); break;
                    case "Psst": newText.Add(7); break;
                    case "Uaah": newText.Add(8); break;
                    case "Uaha": newText.Add(9); break;
                    case "Zzzz": newText.Add(10); break;
                    case "Bauu": newText.Add(11); break;
                    case "Djav": newText.Add(12); break;
                    case "Myau": newText.Add(13); break;
                    case "Gruh": newText.Add(14); break;

                }
            }


            ulong result = 0;
            for (int i = 0; i < newText.Count; i++)
            {
                result += newText[i] * (ulong)Math.Pow(15, newText.Count - 1 - i);
            }
            Console.WriteLine(result);
        }
    }
}

