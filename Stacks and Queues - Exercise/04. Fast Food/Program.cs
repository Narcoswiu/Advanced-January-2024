namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Max());
            }

            while (queue.Count > 0)
            {
                if (queue.Count > 0)
                {
                   

                    if (foodQuantity >= queue.Peek())
                    {
                        foodQuantity -= queue.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Orders left: " + string.Join(' ', queue));
                        return;
                    }


                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}