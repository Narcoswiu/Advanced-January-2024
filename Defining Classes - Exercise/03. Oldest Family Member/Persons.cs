using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Persons
    {
        private string name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Persons()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Persons(int number)
            : this()
        {
            this.Age = number;
        }

        public Persons(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}