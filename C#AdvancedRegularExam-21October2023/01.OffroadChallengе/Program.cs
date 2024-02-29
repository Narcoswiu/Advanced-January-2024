using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace _01.OffroadChallengе
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> indexesFuel = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> consumption = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> quantitiesFuel = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


            int altitude = 0;
            bool hasReachedAny = false;

            while (indexesFuel.Any() && consumption.Any())
            {
                int lastFuel = indexesFuel.Peek();
                int firstIndex = consumption.Peek();
                altitude++;
                if (lastFuel - firstIndex >= quantitiesFuel.Peek())
                {
                    hasReachedAny = true;
                    indexesFuel.Pop();
                    consumption.Dequeue();
                    quantitiesFuel.Dequeue();

                    Console.WriteLine($"John has reached: Altitude {altitude}");
                }
                else
                {

                    Console.WriteLine($"John did not reach: Altitude {altitude}");
                    Console.WriteLine("John failed to reach the top.");

                    if (hasReachedAny)
                    {
                        Console.Write("Reached altitudes: ");
                        List<string> strings = new List<string>();

                        for (int i = 1; i < altitude; i++)
                        {
                            strings.Add($"Altitude {i}");
                        }

                        Console.WriteLine(string.Join(", ", strings));

                    }
                    else
                    {
                        Console.WriteLine("John didn't reach any altitude.");   
                    }
                    return;
                }



            }

            if (quantitiesFuel.Count == 0)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}

