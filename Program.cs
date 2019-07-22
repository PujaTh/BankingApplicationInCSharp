using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BankingAllOperationsProject
{
    class Program
    {
        static SortedList<long,AbsAccount> bank = new SortedList<long,AbsAccount>();
    

        static void Main(string[] args)
        {
            Console.WriteLine("********Welcome to C# Bank*********");
            string Mchoice="y";       
            do
            {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("ENter Initial balance: ");
                
                    double amt=0;                
                    gg:    amt= Convert.ToDouble(Console.ReadLine());
                    while (amt < 1000)
                    { Console.WriteLine("to open account to need to depoist more then 1000.please enter amout again which is more then 1000"); goto gg; }
                
                
                    Console.WriteLine("which a/c you want to open(Saving /Current)");
                    Console.WriteLine("Enter s to open saving and c for opening current");
                    string Achoice = Console.ReadLine();
                    if (Achoice.ToLower().Equals("s"))
                    {
                        AbsAccount acS = new SavingAccount();
                        acS.openAccount(name, amt);
                        bank.Add(AbsAccount.lg_accountNo, acS);
                        Console.WriteLine("your a/c has been added successfully");
                    }
                    else
                    {
                        AbsAccount acC = new CurrentAccount();
                        acC.openAccount(name, amt);
                        bank.Add(AbsAccount.lg_accountNo, acC);
                        Console.WriteLine("your Current a/c has been added successfully");
                    }
                    Console.Write("want to open more a/cs?(y/n)");
                    Mchoice = Console.ReadLine();
             } while (Mchoice.ToLower().Equals("y"));

            
            Console.WriteLine("Accounts served by C# bank are :");
             foreach (var kvp in bank)
                {
                   
                    Console.WriteLine("Account no = {0}, name = {1}", kvp.Key, kvp.Value.str_name);
                }


                     
            Console.WriteLine("Enter your a/c no to perform operations");
            long acNo = Convert.ToInt64(Console.ReadLine());

             while (true)
             {
                 Console.WriteLine();
                 Console.WriteLine("which operation you want to perform");
                 Console.WriteLine("Edit your ac(E)");
                 Console.WriteLine("Deposit Money(D)");
                 Console.WriteLine("Withdraw Money(W)");
                 Console.WriteLine("Check Balance(B)");
                 Console.WriteLine("Transfer Account(T)");
                 Console.WriteLine("Check interest added(I)");
                 Console.WriteLine("Get DEtails of your Account(G)");
                 Console.WriteLine("to remove you account from our bank(R)");
                 Console.WriteLine("log out(L)");

                 string Ochoice = Console.ReadLine();
                 if (Ochoice.ToLower().Equals("e"))
                 {
                     Console.Write("Enter new name: ");
                     string Ename = Console.ReadLine();
                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             AbsAccount eAC = kvp.Value;
                             eAC.editAccount(Ename);
                         }
                     }
                 }

                 else if (Ochoice.ToLower().Equals("d"))
                 {
                     Console.Write("Enter deposit amount: ");
                     double dAmount = Convert.ToDouble(Console.ReadLine());
                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             AbsAccount dAC = kvp.Value;
                             dAC.deposit(dAmount);
                         }
                     }
                 }

                 else if (Ochoice.ToLower().Equals("w"))
                 {
                     Console.Write("Enter withdraw amount: ");
                     double wAmount = Convert.ToDouble(Console.ReadLine());
                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             AbsAccount wAC = kvp.Value;
                             wAC.withdraw(wAmount);
                         }
                     }
                 }

                 else if (Ochoice.ToLower().Equals("b"))
                 {
                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             AbsAccount wAC = kvp.Value;
                             wAC.checkBalance();
                         }
                     }
                 }

                 else if (Ochoice.ToLower().Equals("t"))
                 {
                     AbsAccount fAc,tAc=null;
                     
                   Console.Write("Enter the valid account number where you want to transfer money: ");
                     long tAcNo=Convert.ToInt64(Console.ReadLine());

                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == tAcNo)
                         {
                             tAc = kvp.Value;
                         }
                         
                     }

                     Console.Write("Enter the amount you want to transfer: ");
                     double amt = Convert.ToDouble(Console.ReadLine());

                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             fAc = kvp.Value;
                             fAc.transferAmount(tAc, amt);
                         }
                     }
                     Console.WriteLine("your ac {0} is debited and a/c {1} is credited with {2}rs", acNo,tAcNo,amt);
                     Console.WriteLine("New balance in a/c {0} is {1}rs",tAcNo,tAc.dbl_balance);
                 }

                 else if (Ochoice.ToLower().Equals("i"))
                 {
                     Console.WriteLine("for how many years you want to calculate interest amount if you saved your current amount as fixed principal");
                     int year = Convert.ToInt32(Console.ReadLine());
                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             AbsAccount rAC = kvp.Value;
                             rAC.getRateOfInterest(year);
                         }
                     }
                 }

                 else if (Ochoice.ToLower().Equals("g"))
                 {
                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             AbsAccount gAC = kvp.Value;
                             gAC.getDetails();
                         }
                     }
                 }

                 else if (Ochoice.ToLower().Equals("r"))
                 {
                     foreach (var kvp in bank)
                     {
                         if (kvp.Key == acNo)
                         {
                             AbsAccount rAC = kvp.Value;
                             if (rAC.dbl_balance == 0)
                             {
                                 bank.Remove(acNo);
                                 Console.WriteLine("your accound has been removed from bank successfully");
                             }
                             else
                             {
                                 Console.WriteLine("you can't remove your account as balance in your account is greater than 0");
                             }
                         }
                     }
                 }

                 else
                 {
                     Console.ReadKey();
                     break;
                 }
             }
             Console.WriteLine("all accounta served by C# is having following details");
             foreach (var kvp in bank)
             {
                 Console.WriteLine("account Number = {0}, name = {1},balance = {2}", kvp.Key, kvp.Value.str_name, kvp.Value.dbl_balance);
             }
            
            Console.ReadLine();
        }
    }
}
