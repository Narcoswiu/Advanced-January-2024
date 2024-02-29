namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            int currRowMe = -1;
            int currColMe = -1;
            int allTons = 0;
            int wCount = 0;
            for (int row = 0; row < n; row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    if (currRow[col].ToString() == "S")
                    {
                        currRowMe = row;
                        currColMe = col;
                        matrix[row, col] = "-";
                        continue;
                    }

                    matrix[row, col] = currRow[col].ToString();
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == "up" && currRowMe == 0)
                {
                    currRowMe = n - 1;
                }
                else if (command == "up")

                {
                    currRowMe--;
                }

                if (command == "down" && currRowMe == n - 1)
                {
                    currRowMe = 0;
                }
                else if (command == "down")
                {
                    currRowMe++;
                }

                if (command == "right" && currColMe == n - 1)
                {
                    currColMe = 0;
                }
                else if (command == "right")
                {
                    currColMe++;
                }

                if (command == "left" && currColMe == 0)
                {
                    currColMe = n - 1;
                }
                else if (command == "left")
                {
                    currColMe--;
                }


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (Char.IsDigit(matrix[currRowMe, currColMe][0]))
                        {
                            allTons += int.Parse(matrix[currRowMe, currColMe]);

                            matrix[currRowMe, currColMe] = "-";
                            continue;
                        }
                        else if (matrix[currRowMe, currColMe] == "W")
                        {
                            wCount++;
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currRowMe},{currColMe}]");
                            Environment.Exit(0);
                        }

                    }
                }

            }
            //Last place of me character
            matrix[currRowMe, currColMe] = "S";
            //Quota success
            if (allTons > 19)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - allTons} tons of fish more.");

            }

            if (allTons > 0)
            {
                Console.WriteLine($"Amount of fish caught: {allTons} tons.");
            }

            //If you didn't get into a whirlpool, print the matrix.
            if (wCount == 0)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}