using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public Car(
            string model ,
            int speed,
            int power,
            int weight,
            string Type,
            double tyre1presure,
            int tyre1age,
            double tyre2presure,
            int tyre2age,
            double tyre3presure,
            int tyre3age,
            double tyre4presure,
            int tyre4age
            )
        {
            Tires = new Tires[4];
            Model = model;
            Engine = new Engine { Power = power, Speed = speed };
            Cargo = new Cargo(Type = Type, Weight = weight);
            Tires[0] = new Tires { Pressure = tyre1presure, Age = tyre1age };
            Tires[0] = new Tires { Pressure = tyre2presure, Age = tyre2age };
            Tires[0] = new Tires { Pressure = tyre3presure, Age = tyre3age };
            Tires[0] = new Tires { Pressure = tyre4presure, Age = tyre4age };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }
    }
}
