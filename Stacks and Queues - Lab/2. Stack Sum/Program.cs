using System.Data;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList(); ;
            Stack<int> stack = new Stack<int>(list);
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] arguments = command.Split();
                
                if (arguments[0] == "add")
                {
                    int first = int.Parse(arguments[1]);
                    int second = int.Parse(arguments[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                
                if (arguments[0] == "remove")
                {
                    int numbers = int.Parse(arguments[1]);
                    if (numbers <= stack.Count)
                    {
                        for (int i = 0; i < numbers; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

            }

            int sum = 0;

            while (stack.Count != 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}