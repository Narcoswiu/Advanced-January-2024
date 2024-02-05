namespace _01._Generic_Box_of_String
{
    public class StartUp
    {
        static void Main()
        {
            Box<string> box = new();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }
    }
}