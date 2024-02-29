namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> amountOfmoney =
                new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> sequnceOfIntegers =
                new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int ateFood = 0;
            while (amountOfmoney.Any() && sequnceOfIntegers.Any())
            {
                int lastElementMoney = amountOfmoney.Pop();
                int firstElementIntegers = sequnceOfIntegers.Dequeue();


                if (firstElementIntegers == lastElementMoney)
                {
                    ateFood++;
                }
                else if (lastElementMoney > firstElementIntegers)
                {
                    ateFood++;
                    if (amountOfmoney.Count < 1)
                    {
                        break;
                    }
                    int sequnce = lastElementMoney - firstElementIntegers;
                    int money = amountOfmoney.Pop();
                    money += sequnce;
                    amountOfmoney.Push(money);


                }

            }

            if (ateFood >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {ateFood} foods.");
            }
            else if (ateFood == 1)
            {
                Console.WriteLine($"Henry ate: {ateFood} food.");
            }
            else if (ateFood < 4 && ateFood > 1)
            {
                Console.WriteLine($"Henry ate: {ateFood} foods.");
            }

            else if (ateFood == 0)
            {
                Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}