using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    internal interface IPrintable
    {
        public void PrintDetails();
    }
    internal class Book : IPrintable
    {
       public void PrintDetails()
        {
            Console.WriteLine("Print Book");
        }
    }
    internal class Magazine : IPrintable
    {
        public void PrintDetails()
        {
            Console.WriteLine("Print Magazine");
        }
    }
}
