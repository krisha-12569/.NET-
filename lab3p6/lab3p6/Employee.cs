using System;
using System.Collections.Generic;
using System.Text;

namespace lab3p6
{
    internal class Employee
    {
        public int empID;
        public string empname;
        public int salary;

        public Employee(int empID,string empName,int salary)
        {
            this.empID = empID;
            this.empname = empName;
            this.salary = salary;
        }
         public static void Display(Employee e)
        {
            Console.WriteLine("Employee ID : " + e.empID);
            Console.WriteLine("Employee Name : " + e.empname);
            Console.WriteLine("Employee Salary : " + e.salary);
        }
    }
}