namespace _02._Blind_Man_s_Buff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NandM = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[NandM[0], NandM[1]];
            int currRow = -1;
            int currCol = -1;
            int touchedOpponents = 0;
            int moves = 0;
            for (int row = 0; row < NandM[0]; row++)
            {
                string[]currentRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < NandM[1]; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == "B")
                    {
                        currRow = row;
                        currCol = col;
                        matrix[row, col] = "-";
                        continue;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                if (command == "up" && currRow == 0)
                {
                    currRow += 0;
                    currCol += 0;

                }
                else if (command == "up")
                {
                    currRow--;
                    moves++;
                }

                if (command == "down" && currRow == NandM[0] - 1)
                {
                    currRow += 0;
                    currCol += 0;
                }
                else if (command == "down")
                {
                    currRow++;
                    moves++;
                }

                if (command == "left" && currCol == 0)
                {
                    currRow += 0;
                    currCol += 0;
                }
                else if (command == "left")
                {
                    currCol--;
                    moves++;
                }

                if (command == "right" && currRow == NandM[1] - 1)
                {
                    currRow += 0;
                    currCol += 0;
                }
                else if (command == "right")
                {
                    currCol++;
                    moves++;
                }


                if (matrix[currRow, currCol] == "O")
                {
                    moves--;
                    continue;
                }
                
                if (matrix[currRow, currCol] == "P")
                {
                    matrix[currRow, currCol] = "-";
                    touchedOpponents++;
                }

                if (touchedOpponents == 3)
                {
                    break;
                }
            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {moves}");

        }
    }
}