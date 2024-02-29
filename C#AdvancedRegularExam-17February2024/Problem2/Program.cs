namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[,] matrix = new string[N, N];

            int armorValue = 300;
            int CountEnemyAircraft = 0;
            int currRow = -1;
            int currCol = -1;
            int downAircraft = 0;
            for (int row = 0; row < N; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = currentRow[col].ToString();
                    if (matrix[row, col] == "J")
                    {
                        currRow = row;
                        currCol = col;
                        matrix[row, col] = "-";
                        continue;
                    }

                    if (matrix[row, col] == "E")
                    {

                        CountEnemyAircraft++;
                    }
                }
            }


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up" && currRow == 0)
                {
                    currRow += 0;
                    currCol += 0;

                }
                else if (command == "up")
                {
                    currRow--;

                }

                if (command == "down" && currRow == N - 1)
                {
                    currRow += 0;
                    currCol += 0;
                }
                else if (command == "down")
                {
                    currRow++;

                }

                if (command == "left" && currCol == 0)
                {
                    currRow += 0;
                    currCol += 0;
                }
                else if (command == "left")
                {
                    currCol--;

                }

                if (command == "right" && currCol == N - 1)
                {
                    currRow += 0;
                    currCol += 0;
                }
                else if (command == "right")
                {
                    currCol++;

                }

                if (matrix[currRow, currCol] == "E")
                {
                    downAircraft++;
                    if (downAircraft == CountEnemyAircraft)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                    else if (CountEnemyAircraft > downAircraft)
                    {
                            armorValue -= 100;
                    }
                    matrix[currRow, currCol] = "-";
                }

                if (matrix[currRow, currCol] == "R")
                {
                    matrix[currRow, currCol] = "-";
                    armorValue = 300;
                }

               

                if (armorValue == 0)
                {
                    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{currRow}, {currCol}]!");
                    break;
                }

            }
            matrix[currRow, currCol] = "J";

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}