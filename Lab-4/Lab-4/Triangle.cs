using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class Triangle:Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("Enter base and height: ");
            int basee = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            double area= 0.5 * basee * height;
            Console.WriteLine("Area of Triangle: " + area);
        }
    }
}
