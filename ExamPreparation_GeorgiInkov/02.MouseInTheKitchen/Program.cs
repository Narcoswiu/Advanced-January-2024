//Read numbers of rows and cols of the Matrix
int[] NandM = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
int rows = NandM[0];
int cols = NandM[1];
//Create matrix with info up
char[,] matrix = new char[rows, cols];
int mouseRow = 0;//Place row on mouse
int mouseCol = 0;//Place col on mouse
int cheeseCount = 0;
//Read matrix from the console
// 
for (int row = 0; row < rows; row++)
{
    //Read col
    string currentRow = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentRow[col];

        if (matrix[row, col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
            matrix[mouseRow, mouseCol] = '*';
        }

        if (matrix[row, col] == 'C')
        {
            cheeseCount++;
        }
    }
}
//Read command while until you get the command 'danger'

string command;
while ((command = Console.ReadLine()) != "danger")
{

    if (command == "up")
    {
        if (mouseRow == 0)
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow - 1, mouseCol] == '@')
        {
            continue;
        }

        mouseRow--;
    }
    else if (command == "down")
    {
        if (mouseRow == rows - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow + 1, mouseCol] == '@')
        {
            continue;
        }

        mouseRow++;
    }
    else if (command == "right")
    {
        if (mouseCol == cols - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow, mouseCol + 1] == '@')
        {
            continue;
        }

        mouseCol++;
    }
    else if (command == "left")
    {
        if (mouseCol == 0)
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }

        if (matrix[mouseRow, mouseCol - 1] == '@')
        {
            continue;
        }

        mouseCol--;
    }

    if (matrix[mouseRow, mouseCol] == 'C')
    {
        cheeseCount--;
        matrix[mouseRow, mouseCol] = '*';
        if (cheeseCount == 0)
        {
            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
            break;
        }
    }

    if (matrix[mouseRow, mouseCol] == 'T')
    {
        Console.WriteLine("Mouse is trapped!");
        break;
    }
}

if (command == "danger")
{
    Console.WriteLine("Mouse will come back later!");
}

//Save mouse place in finish
matrix[mouseRow, mouseCol] = 'M';

//Print
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}