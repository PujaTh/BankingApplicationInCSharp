using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAllOperationsProject
{
    class CurrentAccount:AbsAccount
    {
        double minBalaceRequired = 1000;
        public CurrentAccount()
        {
            //lg_accountNo++;  
        }

        public override void openAccount(string name, double balance)
        {
            str_name = name;
            dbl_balance = balance;
            Console.WriteLine("your current acount is opened successfully");
            Console.WriteLine("your current a/c no is: {0}",lg_accountNo);
        }

        public override void editAccount(string name)
        {
            str_name = name;
            Console.WriteLine("Edit Successfull!!");
        }

        public bool withdraw(double outAmt)
        {

            bool chk = true;
            if (outAmt <= dbl_balance)
            {
                try
                {
                    if (dbl_balance < minBalaceRequired)
                    {
                        throw (new ExceptionMinRequirement("you can't withdraw money because current a/c required minimum 1000 rs in account"));
                    }
                    dbl_balance -= outAmt;
                    Console.WriteLine("Withdraw Successfull!!");
                }
                catch (ExceptionMinRequirement ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
            else if (outAmt > dbl_balance)
            {
                chk = false;
            }
            return chk;
        }

        public override void transferAmount(AbsAccount to, double amt)
        {
            dbl_balance = dbl_balance - amt;
            to.dbl_balance += amt;
            Console.WriteLine("transfered Successfull!!");
        }

        public override void getRateOfInterest(int year)
        {
            Console.WriteLine("Rate of interest for Current a/c is 5.5% ");
            Console.WriteLine("interest added in {0} years on fixed amt {1} is {2}", year,dbl_balance, (dbl_balance * 5.5 * year) / 100);
        }

        public override void getDetails()
        {
            Console.WriteLine("Details of your Saving Account is");
            Console.WriteLine("UserName is {0} , Account No is {1} , Balance is {2}", str_name, lg_accountNo, dbl_balance);
        }
    }
}
