using System;

namespace _01._Apocalypse_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> textiles =
                new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> medicaments =
                new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> sorted = new Dictionary<string, int>();
            int countPatch = 0;
            int countBandage = 0;
            int countMedKit = 0;

            while (textiles.Any() && medicaments.Any())
            {
                int sum = textiles.Peek() + medicaments.Peek();
                if (sum == 30)
                {
                    countPatch++;

                    textiles.Dequeue();
                    medicaments.Pop();
                    continue;
                }

                if (sum == 40)
                {
                    countBandage++;
                    textiles.Dequeue();
                    medicaments.Pop();
                    continue;
                }

                if (sum >= 100)
                {

                    countMedKit++;
                    textiles.Dequeue();
                    medicaments.Pop();
                    if (sum > 100)
                    {
                        sum -= 100;
                        medicaments.Push(medicaments.Pop() + sum);
                    }
                    continue;
                }

                textiles.Dequeue();
                medicaments.Push(medicaments.Pop() + 10);
            }

            if (countBandage>0)
            {
                sorted.Add("Bandage", countBandage);
            }

            if (countMedKit>0)
            {
                sorted.Add("MedKit", countMedKit);

            }

            if (countPatch > 0)
            {
                sorted.Add("Patch", countPatch);
            }


            if (!textiles.Any() && !medicaments.Any())
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }

            if (!textiles.Any() && medicaments.Any())
            {
                Console.WriteLine("Textiles are empty.");
            }

            if (!medicaments.Any() && textiles.Any())
            {
                Console.WriteLine("Medicaments are empty.");
            }


            foreach (var item in sorted.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            if (textiles.Any())
            {
                Console.WriteLine("Textiles left: " + string.Join(", ", textiles));
            }

            if (medicaments.Any())
            {
                Console.WriteLine("Medicaments left: " + string.Join(", ", medicaments));
            }
        }
    }
}