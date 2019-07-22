using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAllOperationsProject
{
    class AbsAccount : ITransfer, IROI
    {
       static public long lg_accountNo = 123456789001;
       public string str_name;
       public double dbl_balance;

       public AbsAccount()
       {
           lg_accountNo++;
       }

       public virtual void openAccount(string name, double balance)
       { }

       public virtual void editAccount(string name)
       { }

       public virtual void deposit(double bal)
       {
           dbl_balance += bal;
           Console.WriteLine("Deposit Successfull!!");
       }

       public virtual bool withdraw(double outAmt)
       {
           bool chk = true;
           if (outAmt <= dbl_balance)
           {
               dbl_balance -= outAmt;
               Console.WriteLine("Withdraw Successfull!!");
           }
           else if (outAmt > dbl_balance)
           {
               chk = false;
           }
           return chk;
       }
       public void checkBalance()
       {
           Console.WriteLine("Net Balance in you Account is: {0}",dbl_balance);
       }

       public virtual void transferAmount(AbsAccount to, double amt)
       { }

       public virtual void getRateOfInterest(int year)
       { }
       public virtual void getDetails()
       { }
    }
}
