namespace CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

public class Car
{
    private string make;
    private string model;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;

    public Car()
    {
        this.Make = "VW";
        this.Model = "Golf";
        this.Year = 2025;
        this.FuelQuantity = 200;
        this.FuelConsumption = 10;
    }
    public Car(string make, string model, int year)
    : this()
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return this.year; }
        set { this.year = value; }
    }


    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }
    public void Drive(double distance)
    {
        if (this.FuelQuantity - (distance * this.FuelConsumption) > 0)
        {
            this.FuelQuantity -= (distance * this.FuelConsumption);
        }
        else
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }
    }

    public string WhoAmI()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Make: {this.Make}");
        sb.AppendLine($"Model: {this.Model}");
        sb.AppendLine($"Year: {this.Year}");
        sb.AppendLine($"Fuel: {this.FuelQuantity:F2}");
        return sb.ToString().TrimEnd();
    }
}
public class StartUp
{
    static void Main()
    {
        string make = Console.ReadLine();
        string model = Console.ReadLine();
        int year = int.Parse(Console.ReadLine());
        double fuelQuantity = double.Parse(Console.ReadLine());
        double fuelConsumption = double.Parse(Console.ReadLine());

        Car firstCar = new Car();
        Car secondCar = new Car(make, model, year);
        Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
    }
}
