namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rows = input[0];
            int cols = input[1];

            int squaresFound = 0;
            string[] previousRow = null;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                if (row > 0)
                {
                    for (int col = 0; col < cols - 1; col++)
                    {
                        if (numbers[col] == previousRow[col] 
                            &&previousRow[col+1]== numbers[col] 
                            && numbers[col + 1] == previousRow[col])
                        {

                        }
                    }
                }
            }
        }
    }
}