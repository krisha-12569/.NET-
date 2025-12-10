using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class Circle:Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("Enter radius:");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle: " + area);

        }
    }
}
