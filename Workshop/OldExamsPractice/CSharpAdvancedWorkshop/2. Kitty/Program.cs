//solved 100/100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Kitty
{
    class Program
    {
        static void Main()
        {
            char[] path = Console.ReadLine().ToArray();
            int[] moves = ("0 " + Console.ReadLine()).Split(' ').Select(int.Parse).ToArray();

            int coderSouls = 0;
            int food = 0;
            int deadLocks = 0;
            int kittyPosititon = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                int move = moves[i];

                if (move > 0)
                {
                    kittyPosititon += move;
                    while (kittyPosititon > path.Length - 1)
                    {
                        kittyPosititon -= path.Length;
                    }
                }

                if (move < 0)
                {
                    kittyPosititon += move;
                    while (kittyPosititon < 0)
                    {
                        kittyPosititon += path.Length;
                    }
                }

                switch (path[kittyPosititon])
                {
                    case '@':
                        coderSouls++;
                        path[kittyPosititon] = '0';
                        break;
                    case '*':
                        food++;
                        path[kittyPosititon] = '0';
                        break;
                    case 'x':
                        if (kittyPosititon % 2 == 0)
                        {
                            if (coderSouls > 0)
                            {
                                coderSouls--;
                                deadLocks++;
                                path[kittyPosititon] = '@';
                            }
                            else
                            {
                                Console.WriteLine("You are deadlocked, you greedy kitty!");
                                Console.WriteLine("Jumps before deadlock: {0}", i);
                                return;
                            }
                        }
                        if (kittyPosititon % 2 != 0)
                        {
                            if (food > 0)
                            {
                                food--;
                                deadLocks++;
                                path[kittyPosititon] = '*';
                            }
                            else
                            {
                                Console.WriteLine("You are deadlocked, you greedy kitty!");
                                Console.WriteLine("Jumps before deadlock: {0}", i);
                                return;
                            }

                        }
                        break;
                }
            }
            Console.WriteLine("Coder souls collected: {0}", coderSouls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadLocks);
        }
    }
}
