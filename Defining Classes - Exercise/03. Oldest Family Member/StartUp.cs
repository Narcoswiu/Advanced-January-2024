using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] personProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Persons person = new Persons(personProperties[0], int.Parse(personProperties[1]));
                family.AddMember(person);
            }

            Persons oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}