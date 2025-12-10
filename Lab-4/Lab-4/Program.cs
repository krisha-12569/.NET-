namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter two numbers: ");
            //int n1=Convert.ToInt32(Console.ReadLine());
            //int n2=Convert.ToInt32(Console.ReadLine());
            //Calculator calculator = new Calculator();
            //int sum1 = calculator.Add(n1,n2);
            //Console.WriteLine("Sum of two integers: " + sum1);

            //Console.WriteLine("Enter three numbers:");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());

            //int sum2=calculator.Add(m1,m2,m3);
            //Console.WriteLine("Sum of three integers: " + sum2);

            //Console.WriteLine("Enter 2 double numbers:");
            //double c1 = Convert.ToDouble(Console.ReadLine());
            //double c2 = Convert.ToDouble(Console.ReadLine());

            //double sum3 = calculator.Add(c1, c2);
            //Console.WriteLine("Sum of 2 double numbers: " + sum3);

            //Console.WriteLine("Enter Name: ");
            //string name = Console.ReadLine();
            //Employee employee1 = new Employee();
            //employee1.Display(name);

            //Console.WriteLine("Enter Name,age: ");
            //string name2 = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());

            //employee1.Display(name2, age);

            //Console.WriteLine("Enter Name,age and salary: ");
            //string name3 = Console.ReadLine();
            //int age3 = Convert.ToInt32(Console.ReadLine());
            //int salary= Convert.ToInt32(Console.ReadLine());
            //employee1.Display(name3, age3, salary); 

            //Person person = new Person();
            //Console.WriteLine(person.name);

            //User user = new User();
            //user.Display();

            //user.id;

            //Console.WriteLine("Enter 1 for dog sound and 2 for cat sound: ");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //Animal animal;
            //if (choice == 1)
            //{
            //    animal = new Dog();
            //}
            //else if (choice == 2)
            //{
            //    animal = new Cat();
            //}
            //else
            //{
            //    animal = new Animal();
            //    Console.WriteLine("Invalid choice");
            //}
            //animal.Sound();

            Console.WriteLine("Enter 1 for CIRCLE and 2 for rectangle and 3 for triangle ared: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Shape shape;
            if (choice == 1)
            {
                shape = new Circle();
            }
            else if (choice == 2)
            {
                shape = new Rectangle();
            }
            else if (choice == 3)
            {
                shape = new Triangle();
            }
            else
            {
                shape = new Shape();
                Console.WriteLine("Invalid choice");
            }
            shape.CalculateArea();
        }
    }
}
