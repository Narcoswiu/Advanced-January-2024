namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int rows = 0; rows < n; rows++)
            {
                int[] columns = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows,cols] = columns[cols];
                }
            }

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    sum += matrix[row, col = row];
                }
            }
            Console.WriteLine(sum);
        }
    }
}