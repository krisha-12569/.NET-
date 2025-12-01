using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    internal class Student
    {
        public string Name;
        public int rollno;
        public int marks;

        public void PrintData()
        {
            Console.WriteLine(this.Name + " " +this.rollno +" " +this.marks);
        }
    }
}
