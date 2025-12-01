using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3p2
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string holderName;
        public double balance;

        public BankAccount(int AccountNumber , string holderName , double balance)
        {
            this.AccountNumber = AccountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public double Deposit(double amount)
        {
            return balance += amount;
        }
        public double Withdraw(double withdrawalammount)
        {
           if(this.balance >= withdrawalammount)
            {
                try
                {
                    return balance -= withdrawalammount;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error occured :" + ex.Message);
                    return balance;
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return balance;
            }
        }
    }
}
