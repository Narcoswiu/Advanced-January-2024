using System.Data;

int sizeOfMatrix = int.Parse(Console.ReadLine());

char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];
int currRow = -1;
int currCol = -1;
int amount = 100;
for (int row = 0; row < sizeOfMatrix; row++)
{
    string currentRow = Console.ReadLine();
    for (int col = 0; col < sizeOfMatrix; col++)
    {
        matrix[row, col] = currentRow[col];
        if (matrix[row, col] == 'G')
        {
            currRow = row;
            currCol = col;
            matrix[row, col] = '-';
            continue;
        }
    }
}

string command;
while ((command = Console.ReadLine()) != "end")
{
  
    if (command == "up" && currRow == 0)
    {
        Console.WriteLine("Game over! You lost everything!");
        break;
    }
    else if (command == "up")
    {
        currRow--;
    }

    if (command == "down" && currRow == sizeOfMatrix - 1)
    {
        Console.WriteLine("Game over! You lost everything!");
        break;
    }
    else if (command == "down")
    {
        currRow++;
    }

    if (command == "left" && currCol == 0)
    {
        Console.WriteLine("Game over! You lost everything!");
        break;

    }
    else if (command == "left")
    {
        currCol--;
    }

    if (command == "right" && currRow == sizeOfMatrix - 1)
    {
        Console.WriteLine("Game over! You lost everything!");
        break;
    }
    else if (command == "right")
    {
        currCol++;
    }

    if (matrix[currRow, currCol] == 'W')
    {
        amount += 100;
        matrix[currRow, currCol] = '-';
    }

    if (matrix[currRow, currCol] == 'P')
    {
        amount -= 200;
    }

    if (matrix[currRow, currCol] == 'J')
    {
        amount += 100000;
        Console.WriteLine("You win the Jackpot!");
        Console.WriteLine($"End of the game. Total amount: {amount}$");
        
        for (int row = 0; row < sizeOfMatrix; row++)
        {
            for (int col = 0; col < sizeOfMatrix; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
        break;
    }

    if (amount <= 0)
    {
        Console.WriteLine($"Game over! You lost everything!");
        break;
    }
   
}
matrix[currRow, currCol] = 'G';


if (command == "end")
{
    Console.WriteLine($"End of the game. Total amount: {amount}$");
    for (int row = 0; row < sizeOfMatrix; row++)
    {
        for (int col = 0; col < sizeOfMatrix; col++)
        {
            Console.Write(matrix[row,col]);
        }
        Console.WriteLine();
    }
}
