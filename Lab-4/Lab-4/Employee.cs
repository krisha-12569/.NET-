using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class Employee
    {
        public string name;
        public int age;
        public int salary;

        public void Display(string Name)
        {
            Console.WriteLine("Name =" + Name);
        }

        public void Display(string Name,int Age)
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Age =" + Age);
        }
        public void Display(string Name,int Age,float Salary)
        {
            Console.WriteLine("Name= " + Name);
            Console.WriteLine("Age= " + Age);
            Console.WriteLine("Salary= " + Salary);
        }
    }

}
