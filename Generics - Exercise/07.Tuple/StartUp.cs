using _07.Tuple;


string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] numbersTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
CustomTuple<string,string> nameAddres = new($"{personTokens[0]} {personTokens[1]}", personTokens[2]);

CustomTuple<string,int> nameBeer = new(drinkTokens[0], int.Parse(drinkTokens[1]));

CustomTuple<int,double> numbers = new(int.Parse(numbersTokens[0]), double.Parse(numbersTokens[1]));

Console.WriteLine(nameAddres.ToString());
Console.WriteLine(nameBeer.ToString());
Console.WriteLine(numbers.ToString());
//CustomTuple<int,int> customTuple = new(1,2);

