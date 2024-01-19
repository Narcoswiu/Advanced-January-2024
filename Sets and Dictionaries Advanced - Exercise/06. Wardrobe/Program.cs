using System.Threading.Channels;

namespace StackAndQueuesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new();

            FillWardrobe(lines, wardrobe);

            string[] searchItem = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (color.Key == searchItem[0] && item.Key == searchItem[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }

        }

        private static void FillWardrobe(int lines, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] newEntry = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = newEntry[0];
                string[] newClothes = newEntry[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                addColorToWardrobe(wardrobe, color);
                AddClothesToColor(wardrobe, color, newClothes);
            }
        }

        private static void AddClothesToColor(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string[] newClothes)
        {
            foreach (string item in newClothes)
            {
                if (wardrobe[color].ContainsKey(item) == false)
                {
                    wardrobe[color].Add(item, 1);
                }
                else
                {
                    wardrobe[color][item]++;
                }
            }
        }

        private static void addColorToWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string color)
        {
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }
        }
    }
}