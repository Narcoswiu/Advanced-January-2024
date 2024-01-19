namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] column = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = column[col];
                }

            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split();
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);
                for (int rowss = 0; rowss < rows; rowss++)
                {


                    for (int colss = 0; colss < rows; colss++)
                    {
                        if (row > -1 && row < matrix.GetLength(0) && col > -1 && col < matrix.GetLength(1))
                        {
                            if (arguments[0] == "Add")
                            {
                                matrix[row, col] = matrix[row, col] + value;
                            }
                            else if (arguments[0] == "Subtract")
                            {

                                matrix[row, col] -= value;
                            }
                        }

                    }
                }
                if (!(row > -1 && row < matrix.GetLength(0) && col > -1 && col < matrix.GetLength(1)))
                {
                    Console.WriteLine("Invalid coordinates");
                }
            };

            for (int row = 0; row < rows; row++)
            {


                for (int col = 0; col < rows; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}