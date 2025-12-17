using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal can eat");
        }
    }
    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog can bark");
        }
    }
}
