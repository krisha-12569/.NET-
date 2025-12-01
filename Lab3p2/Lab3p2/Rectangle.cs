using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3p2
{
    internal class Rectangle
    {
        public double length;
        public double width;

        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Area()
        {
            return this.length * this.width;
        }
    }
}
