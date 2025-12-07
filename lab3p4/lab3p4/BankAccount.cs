using System;
using System.Collections.Generic;
using System.Text;

namespace lab3p4
{
    internal class BankAccount
    {
        public int accountNumber;
        public string holdername;
        public int balance;

        public BankAccount(int accountNumber,string holdername,int balance)
        {
            this.accountNumber = accountNumber;
            this.holdername = holdername;
            this.balance = balance;
        }

        public int Deposit(int amount)
        {
            return this.balance += amount;
        }

        public int Withdraw(int amount)
        {
            try
            {
                if(amount >= balance || amount <0)
                {
                    throw new CustomException("Insufficient amount");
                }
                else
                {
                    return this.balance -= amount;
                }
            }
            catch(CustomException e)
            {
                Console.WriteLine("Error ocurred : " + e.Message);
                return this.balance;
            }
        }

    }
}
