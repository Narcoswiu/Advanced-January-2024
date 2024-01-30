namespace Date_Modifier
{
    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            Console.WriteLine(DateModifier.DateDifference(firstDate,secondDate));
        }
    }
}