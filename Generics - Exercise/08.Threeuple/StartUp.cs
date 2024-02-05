using _08.Threeuple;


string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] bankTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
Threeuple<string, string,string> person = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], personTokens[3]);

Threeuple<string, int,bool> drinks = new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

Threeuple<string, double,string> bankAcc = new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

Console.WriteLine(person.ToString());
Console.WriteLine(drinks.ToString());
Console.WriteLine(bankAcc.ToString());