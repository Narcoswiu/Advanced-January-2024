using System.Threading.Channels;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVat =
                x => x * 1.20m;

            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            decimal[] nums = tokens.Select(decimal.Parse).ToArray();
            decimal[] numsWithVat = nums.Select(addVat).ToArray();
            Array.ForEach(numsWithVat, x => Console.WriteLine($"{x:F2}"));
        }
    }
}