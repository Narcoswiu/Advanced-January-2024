namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person first = new Person();
            Person second = new Person(12);
            Person third = new Person("Ivan",12);
        }
    }
}