using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_classAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the Account Number");
            string accNum = Console.ReadLine();

            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Account Type");
            string accType = Console.ReadLine();

            Accounts account = new Accounts();

            account.accept(accNum, name, accType);

            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();

            while (true)
            {
                double amount = 0;
                Console.WriteLine("\nD -----> Deposit");
                Console.WriteLine("W -----> Withdrawal");
                Console.WriteLine("E -----> Exist");

                Console.Write("Select any operation mentioned above to continue :");
                string transactionType = Console.ReadLine();

                if(transactionType.ToLower().Equals("d"))
                {
                    Console.WriteLine("Amount : ");
                    amount = Convert.ToDouble(Console.ReadLine());

                    account.credit(amount);
                    Console.WriteLine("Balance : {0}",account.getBalance());
                    Console.ReadKey();
                    continue;
                }
                if (transactionType.ToLower().Equals("w"))
                {
                    Console.WriteLine("Amount : ");
                    amount = Convert.ToDouble(Console.ReadLine());

                    account.debit(amount);
                    Console.WriteLine("Balance : {0}", account.getBalance());
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    account.display();
                    Console.ReadKey();
                    break;
                }
            }
        }
    }

    public class Accounts
    {
        private string accountNo;
        private string customerName;
        private string accountType;
        private string transactionType;
        private double amount;
        private double  balance;
        
        public void accept(string accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            amount = balance = 0;
        }
       
        public double credit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid amount");
            }
            else
            {
                this.balance += amount;
            }

            return this.balance;
        }
        
        public double debit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
            }

            if (this.balance <= 0 || this.balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.balance -= amount;
            }

            return this.balance;
        }
        
        public void display()
        {
            Console.WriteLine("Account Number : {0}", accountNo);
            Console.WriteLine("Customer Name : {0}", customerName);
            Console.WriteLine("Account Type : {0}", accountType);
            Console.WriteLine("Balance : {0}", balance);
        }
       
        public double getBalance()
        {
            return this.balance;
        }
        
    }
}
