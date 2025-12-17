using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    internal class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("Area is calculating");
        }
    }
    internal class Circle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of circle : " + area);
        }
    }
    internal class Rectangle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Enter Length and breadth: ");
            int  length = Convert.ToInt32(Console.ReadLine());
            int breadth= Convert.ToInt32(Console.ReadLine());
            double area = length * breadth;
            Console.WriteLine("Area of Rectangle : " + area);
        }
    }
}
