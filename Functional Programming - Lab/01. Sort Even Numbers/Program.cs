namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            int[] nums = tokens.Select(x => int.Parse(x)).ToArray();
            int[] evenNums = nums.Where(x => x % 2 == 0).ToArray();
            int[] orderedEvenNums = evenNums.OrderBy(n => n).ToArray();
            Console.WriteLine(string.Join(", ",orderedEvenNums));
        }
    }
}