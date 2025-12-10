using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class Rectangle:Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("Enter length and breadth: ");
            int length=Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}
