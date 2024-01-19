namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           Stack<char> text = new Stack<char>();
            foreach (char item in input)
            {
                text.Push(item);
            }
            
            while (text.Count != 0)
            {
                Console.Write(text.Pop());
            }
        }
    }
}