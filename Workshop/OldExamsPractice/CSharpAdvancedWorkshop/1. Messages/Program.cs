//solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace task1_Messages2
{
    class Program
    {
        static BigInteger GetNumber(string input)
        {
            char[] array = new char[input.Length / 3];

            for (int i = 0; input.Length > 0; i++)
            {
                string num = input.Substring(0, 3);
                input = input.Remove(0, 3);

                char number = '0';
                switch (num)
                {
                    case "cad": number = '0'; break;
                    case "xoz": number = '1'; break;
                    case "nop": number = '2'; break;
                    case "cyk": number = '3'; break;
                    case "min": number = '4'; break;
                    case "mar": number = '5'; break;
                    case "kon": number = '6'; break;
                    case "iva": number = '7'; break;
                    case "ogi": number = '8'; break;
                    case "yan": number = '9'; break;

                }
                array[i] = number;

            }
            string firstNumberAsText = new string(array);
            return BigInteger.Parse(firstNumberAsText);
        }


        static void Main()
        {
            string input = Console.ReadLine();

            char operrator = char.Parse(Console.ReadLine());

            string secondInput = Console.ReadLine();

            BigInteger firstNumber = GetNumber(input);
            BigInteger secondNumber = GetNumber(secondInput);

            BigInteger result = 0;

            switch (operrator)
            {
                case '+': result = firstNumber + secondNumber; break;
                case '-': result = firstNumber - secondNumber; break;
            }

            string resultAsText = result.ToString();
            string[] lastResult = new string[resultAsText.Length * 3];

            for (int i = 0; i < resultAsText.Length; i++)
            {
                switch (resultAsText[i])
                {
                    case '0': lastResult[i] = "cad"; break;
                    case '1': lastResult[i] = "xoz"; break;
                    case '2': lastResult[i] = "nop"; break;
                    case '3': lastResult[i] = "cyk"; break;
                    case '4': lastResult[i] = "min"; break;
                    case '5': lastResult[i] = "mar"; break;
                    case '6': lastResult[i] = "kon"; break;
                    case '7': lastResult[i] = "iva"; break;
                    case '8': lastResult[i] = "ogi"; break;
                    case '9': lastResult[i] = "yan"; break;
                }
            }
            Console.WriteLine(string.Join("", lastResult));

        }
    }
}
