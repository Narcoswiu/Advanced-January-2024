namespace RawData
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carProperties = Console.ReadLine()
                    .Split(" ");

                Car car= new Car(carProperties[0],
                    int.Parse(carProperties[1]),
                    int.Parse(carProperties[2]),
                int.Parse(carProperties[3]),
                    carProperties[4],
                    );
            }
        }
    }
}