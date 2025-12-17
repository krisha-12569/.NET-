using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    abstract class Payment
    {
        public abstract void MakePayment();
    }
    internal class CreditCardPayment : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(amount);

            try
            {
                if (amount < 100)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
        }
    }

    internal class UPIPayment : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Enter amount by UPI: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(amount);

            try
            {
                if (amount < 100)
                {
                    throw new Exception();
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }

        }
    }
}
