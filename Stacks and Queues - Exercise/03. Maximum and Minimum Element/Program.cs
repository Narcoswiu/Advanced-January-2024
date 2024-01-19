namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> integerStack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                if (input[0] == 1)
                {
                    integerStack.Push(input[1]);
                }
                else if (input[0] == 2)
                {
                    integerStack.Pop();
                }
                else if (input[0] == 3&&integerStack.Any())
                {
                    
                    Console.WriteLine(integerStack.Max());
                }
                else if (input[0] == 4 && integerStack.Any())
                {
                    Console.WriteLine(integerStack.Min());
                }

            }

            Console.WriteLine(string.Join(", ",integerStack));
        }
    }
}