using System;
using System.Collections.Generic;
using System.Text;

namespace lab3p6
{
    internal class Person
    {
        public string Name;
        public int Age;
        public string City;

        public Person()
        {
            Name = "test";
            Age = 20;
            City = "Rajkot";
        }
        public Person(string Name)
        {
            this.Name = Name;
            Age = 0;
            City = "unknown";
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            City= "unknown";
        }

        public Person(string Name,int Age,string City)
        {
            this.Name = Name;
            this.Age = Age;
            this.City = City;
        }
        public void Display()
        {
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Name : " + this.Age);
            Console.WriteLine("Name : " + this.City);
        }
    }
}
