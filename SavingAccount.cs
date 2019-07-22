using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAllOperationsProject
{
    class SavingAccount : AbsAccount
    {
        double maxAmtPerDay = 4000;
        public SavingAccount()
        {
           // lg_accountNo++;  
        }
        ~SavingAccount()
        {
            Console.WriteLine("your all information of Saving account is removed successfully");
        }
        public override void  openAccount(string name,double balance)
        {
            str_name = name;
            dbl_balance = balance;
            Console.WriteLine("your Saving acount is opened successfully");
            Console.WriteLine("saving a/c no is : {0}", lg_accountNo);
        }
        public override void editAccount(string name)
        {
            str_name = name;
            Console.WriteLine("Edit Successfull!!");
        }

        public override void deposit(double depAmt)
        {
            try
            {
                if (depAmt > maxAmtPerDay)
                {
                    throw (new ExceptionMaxDepositPerDay("u can't deposit more than 4000 at a time as per policy of saving account"));
                }
                else
                {
                    dbl_balance += depAmt;
                    Console.WriteLine("Deposit Successfull!!");
                }
            }
            catch (ExceptionMaxDepositPerDay ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

        public override void transferAmount(AbsAccount to, double amt)
        {
            dbl_balance = dbl_balance - amt;
            to.dbl_balance += amt;
            Console.WriteLine("money transfered Successfully");
        }

        public override void getRateOfInterest(int year)
        {
            Console.WriteLine("Rate of interest for saving a/c is 10.5% ");
            Console.WriteLine("interest added in {0} years on {1} amt will be {2}", year,dbl_balance,(dbl_balance * 10.5 * year) / 100);
        }

        public override void getDetails()
        {
            Console.WriteLine("Details of your Saving Account is");
            Console.WriteLine("UserName is {0} , Account No is {1} , Balance is {2}",str_name,lg_accountNo,dbl_balance);
        }
    }
}
