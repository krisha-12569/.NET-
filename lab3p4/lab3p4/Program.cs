using System.Runtime.CompilerServices;

namespace lab3p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account num,holder name and balance:");
            int accountNo = Convert.ToInt32(Console.ReadLine());
            string holdername = Console.ReadLine();
            int balance = Convert.ToInt32(Console.ReadLine());
            BankAccount account = new BankAccount(accountNo, holdername, balance);

            Console.WriteLine("Enter 1 to deposit and 2 for withdraw : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter amount to deposit : ");
                int amount = Convert.ToInt32(Console.ReadLine());
                int total_balance = account.Deposit(amount);
                Console.WriteLine("Total balance : " + total_balance);
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter amount to withdraw : ");
                int amount = Convert.ToInt32(Console.ReadLine());
                int total_balance = account.Withdraw(amount);
                Console.WriteLine("Total balance : " + total_balance);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
