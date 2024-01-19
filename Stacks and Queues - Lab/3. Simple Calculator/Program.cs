namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            
            Stack<string> strings = new Stack<string>();
            
            foreach (var s in input)
            {
                strings.Push(s);
            }

            int sum = int.Parse(strings.Pop());
            while (strings.Count > 0)
            {
                string currentString = strings.Pop();
                if (currentString == "+")
                {
                    sum += int.Parse(strings.Pop());
                    continue;
                }
                else if (currentString == "-")
                {
                    sum -= int.Parse(strings.Pop());
                    continue;
                }
            }

            Console.WriteLine(sum);
        }
    }
}