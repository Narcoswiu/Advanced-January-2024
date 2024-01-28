namespace CarManufacturer
{

    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Year = 1992;
            car.Make = "VW";
            car.Model = "MK3";

            Console.WriteLine($"Make: {car.Make}; Model: {car.Model}; Year: {car.Year}");
        }
    }
}