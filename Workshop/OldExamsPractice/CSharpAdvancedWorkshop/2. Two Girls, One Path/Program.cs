// Solved 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TwoGirslOnePath
{
    class Program
    {
        static void Main()
        {
            BigInteger[] path = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            int mollyPosition = 0;
            int dollyPosition = path.Length - 1;

            BigInteger mollyFlowers = 0;
            BigInteger dollyFlowers = 0;

            string winner = "";

            while (true)
            {
                if (path[mollyPosition] == 0 || path[dollyPosition] == 0)
                {
                    if (path[mollyPosition] == 0 && path[dollyPosition] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (path[mollyPosition] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (path[dollyPosition] == 0)
                    {
                        winner = "Molly";
                    }

                    mollyFlowers += path[mollyPosition];
                    dollyFlowers += path[dollyPosition];
                    break;
                }

                BigInteger currentMollyFlowers = path[mollyPosition];
                BigInteger currentDollyFlowers = path[dollyPosition];

                if (mollyPosition == dollyPosition)
                {
                    path[mollyPosition] = currentMollyFlowers % 2;
                    mollyFlowers += currentMollyFlowers / 2;
                    dollyFlowers += currentDollyFlowers / 2;
                }
                else
                {
                    path[mollyPosition] = 0;
                    path[dollyPosition] = 0;

                    mollyFlowers += currentMollyFlowers;
                    dollyFlowers += currentDollyFlowers;
                }

                mollyPosition = (int)((mollyPosition + currentMollyFlowers) % path.Length);
                dollyPosition = (int)((dollyPosition - currentDollyFlowers) % path.Length);

                if (dollyPosition < 0)
                {
                    dollyPosition += path.Length;
                }
            }
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
        }
    }
}
