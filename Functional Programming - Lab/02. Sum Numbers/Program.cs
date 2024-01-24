namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] nums = input.Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}