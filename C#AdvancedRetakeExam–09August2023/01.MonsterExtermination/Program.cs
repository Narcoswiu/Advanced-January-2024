using Microsoft.VisualBasic;
using System;
using System.Linq.Expressions;

namespace _01.MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> monsters =
                new(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> strikes =
                new(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int monsterRipCount = 0;

            while (monsters.Any() && strikes.Any())
            {
                int armour = monsters.Peek();
                int strike = strikes.Peek();
                if (armour <= strike)
                {
                    monsterRipCount++;
                    strike -= armour;

                    if (strike == 0)
                    {
                        strikes.Pop();
                        monsters.Dequeue();
                    }
                    else
                    {
                        monsters.Dequeue();
                        if (strikes.Count == 1)
                        {
                            strikes.Pop();
                            strikes.Push(strike);
                            continue;
                        }
                        else
                        {
                            strikes.Pop();
                            int tempStrike = strike;
                            strikes.Push(strikes.Pop() + tempStrike);
                        }
                    }
                }
                else
                {
                    armour -= strike;
                    strikes.Pop();
                    monsters.Dequeue();
                    monsters.Enqueue(armour);
                }

            }

            if (!monsters.Any())
            {
                Console.WriteLine("All monsters have been killed!");
            }

            if (!strikes.Any())
            {
                Console.WriteLine("The soldier has been defeated.");
            }
            Console.WriteLine($"Total monsters killed: {monsterRipCount}");
        }
    }
}