namespace ImplementingCustomList_StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(5);
            list.Add(4);
            list.Add(4);
            list.Swap(0,1);
            list.ForEach(i=> Console.WriteLine(i));
        }
    }
}