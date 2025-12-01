using System.Drawing;

namespace Lab3p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter length and breadth : ");
            //double length = Convert.ToDouble(Console.ReadLine());
            //double width = Convert.ToDouble(Console.ReadLine());
            //Rectangle rectangle = new Rectangle(length,width);

            //double area=rectangle.Area();
            //Console.WriteLine("AREA IS : " + area);

            //Console.WriteLine("Enter two numbers : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //TryCatch t1 = new TryCatch(n1, n2);

            //int result = t1.calculate();
            //Console.WriteLine("Result = " + result);

            Console.WriteLine("Enter account no , holder name and balance : ");
            int AccountNo = Convert.ToInt32(Console.ReadLine());
            string holdername = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            BankAccount b1 = new BankAccount(AccountNo, holdername, balance);
            Console.WriteLine("Enter 1 to deposit and 2 for withdrawal : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Enter amount to deposit : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                double total_balance = b1.Deposit(amount);
                Console.WriteLine("Total balance : " + total_balance);
            }
            else if(n == 2)
            {
                Console.WriteLine("Enter amount for withdrawal : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                double total_balance = b1.Withdraw(amount);
                Console.WriteLine("Total balance : " + total_balance);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        } 
    }
}
