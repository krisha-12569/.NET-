using System.ComponentModel.DataAnnotations;

namespace lab3p6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter employee ID,name and salary : ");
            //int empID = Convert.ToInt32(Console.ReadLine());
            //string empName = Console.ReadLine();
            //int salary = Convert.ToInt32(Console.ReadLine());
            //Employee e1 = new Employee(empID, empName, salary);
            //Employee.Display(e1);

            Person p1 = new Person();
            Person p2 = new Person("test");
            Person p3 = new Person("Darshan", 18);
            Person p4 = new Person("Uni", 50, "Mumbai");

            p1.Display();
            p2.Display();
            p3.Display();
            p4.Display();


        }
    }
}
