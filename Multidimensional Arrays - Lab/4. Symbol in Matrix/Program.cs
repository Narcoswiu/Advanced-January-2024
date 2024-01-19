namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string rowss = Console.ReadLine();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowss[cols];
                }
            }
            char findSymbol = char.Parse(Console.ReadLine());
            bool finded = false;
            int row = 0;
            int col = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == findSymbol)
                    {
                        finded = true;
                        row = rows;
                        col = cols;
                        break;
                    }
                    
                }
                if (finded == true)
                {
                    break;
                }
            }

            if (finded) 
            {
                Console.WriteLine($"({row}, {col})");
            }
            else
            {
                Console.WriteLine($"{findSymbol} does not occur in the matrix");

            }
        }
    }
}
