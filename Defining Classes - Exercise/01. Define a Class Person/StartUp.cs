namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Age = 20;
            newPerson.Name = "Peter";
            newPerson.Age = 18;
            newPerson.Name = "George";
            newPerson.Age = 43;
            newPerson.Name = "Jose";

        }
    }
}