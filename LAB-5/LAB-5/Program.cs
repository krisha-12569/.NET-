namespace LAB_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog=new Dog();
            //dog.Eat();
            //dog.Bark();

            //ElectricCar car = new ElectricCar();
            //car.type1();
            //car.type2();
            //car.type3();

            //Console.WriteLine("Enter choice 1 for circle and 2 for rectangle : ");
            //int choice=Convert.ToInt32(Console.ReadLine());

            //Shape shape;
            //if (choice == 1)
            //{
            //    shape = new Circle();
            //}
            //else if (choice == 2) {
            //    shape = new Rectangle();
            //}
            //else
            //{
            //    shape = new Shape();
            //    Console.WriteLine("Invalid choice");
            //}
            //shape.Area();

            //Console.WriteLine("Enter 1 for fan and light: ");
            //int choice=Convert.ToInt32(Console.ReadLine());

            //Appliance appliance;
            //if (choice == 1)
            //{
            //    appliance = new Fan();
            //    appliance.TurnOn();
            //}
            //else if (choice == 2)
            //{
            //    appliance = new Light();
            //    appliance.TurnOn();
            //}
            //else
            //{
            //  //appliance=new Appliance();
            //   Console.WriteLine("Invalid choice");
            //}

            //Book book=new Book();
            //book.PrintDetails();

            //Magazine magazine = new Magazine();
            //magazine.PrintDetails();

            //Robot robot = new Robot();
            //robot.MakeSound();
            //robot.Move();


            Console.WriteLine("Enter 1 to make payment by UPI and 2 for Credit card: ");
            int choice=Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                UPIPayment upi=new UPIPayment();
                upi.MakePayment();
            }
            else if(choice==2)
            {
                 CreditCardPayment creditCardPayment = new CreditCardPayment();
                creditCardPayment.MakePayment();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
