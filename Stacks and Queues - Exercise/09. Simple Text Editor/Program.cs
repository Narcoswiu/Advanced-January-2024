namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int direction = int.Parse(commands[0]);
                if (direction == 1)
                {
                    string someString = commands[1];
                    
                    
                }
                else if (direction == 2)
                {
                    int count = int.Parse(commands[1]);
                }
                else if (direction == 3)
                {
                    int index = int.Parse(commands[1]);

                }
                else if (direction == 4)
                {
                    int undoes = int.Parse(commands[1]);

                }
            }
              
        }
    }
}