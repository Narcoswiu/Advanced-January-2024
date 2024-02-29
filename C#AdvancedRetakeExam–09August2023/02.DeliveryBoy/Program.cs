namespace _02.DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NandM = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int N = NandM[0];
            int M = NandM[1];
            string[,] matrix = new string[N, M];
            int currRow = -1;
            int currCol = -1;
            bool boundOfMatrix = false;
            for (int row = 0; row < N; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = currentRow[col].ToString();
                    if (matrix[row, col] == "B")
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up" && currRow == 0)
                {
                    if (currRow > 0)
                    {
                        if (matrix[currRow - 1, currCol] == "*")
                        {
                            continue;
                        }
                        if (matrix[currRow, currCol] != "R")
                        {
                            matrix[currRow, currCol] = ".";
                        }
                        currRow--;
                    }
                    else
                    {
                        if (matrix[currRow, currCol] == "-")
                        {
                            matrix[currRow, currCol] = ".";
                        }
                        boundOfMatrix = true;
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }
                }

                if (command == "down" && currRow == N - 1)
                {
                    boundOfMatrix = true;
                    Console.WriteLine("The delivery is late. Order is canceled.");
                    break;
                }
                else if (command == "down")
                {
                    currRow++;

                }

                if (command == "left" && currCol == 0)
                {
                    boundOfMatrix = true;
                    Console.WriteLine("The delivery is late. Order is canceled.");
                    break;
                }
                else if (command == "left")
                {
                    currCol--;
                }

                if (command == "right" && currCol == M - 1)
                {
                    boundOfMatrix = true;
                    Console.WriteLine("The delivery is late. Order is canceled.");
                    break;
                }
                else if (command == "right")
                {
                    currCol++;
                }

                for (int row = 0; row < N; row++)
                {

                    for (int col = 0; col < M; col++)
                    {
                        if (matrix[row, col] == "B")
                        {
                            if (boundOfMatrix)
                            {
                                matrix[row, col] = " ";
                            }
                        }

                        if (matrix[currRow, currCol] == "-")
                        {
                            matrix[currRow, currCol] = ".";
                            break;
                        }

                        if (matrix[currRow, currCol] == "P")
                        {
                            matrix[currRow, currCol] = "R";
                            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                            break;
                        }

                        if (matrix[currRow, currCol] == "*")
                        {
                            if (command == "right" && command == "left")
                            {
                                currCol--;
                            }
                            else
                            {
                                currRow--;
                            }


                        }


                        if (matrix[currRow, currCol] == "A")
                        {
                            matrix[currRow, currCol] = "P";
                            Console.WriteLine("Pizza is delivered on time! Next order...");
                            break;
                        }

                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}