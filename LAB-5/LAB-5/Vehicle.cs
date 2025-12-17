using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    internal class Vehicle
    {
        public void type1()
        {
            Console.WriteLine("Vehicle class");
        }
    }
    internal class Car : Vehicle
    {
        public void type2()
        {
            Console.WriteLine("Car class");
        }
    }
    internal class ElectricCar : Car
    {
        public void type3()
        {
            Console.WriteLine("Electric car class");
        }
    }

}
