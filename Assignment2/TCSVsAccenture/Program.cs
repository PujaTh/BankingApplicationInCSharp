using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCSVsAccenture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ID if Employee");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the name of Employee");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the department of Employee");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter the desgination of Employee");
            string desg = Console.ReadLine();
            Console.WriteLine("Enter the basic salary of Employee");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENter the Service period completed by employee");
            double serPeriod = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Company(tcs\\accenture)");
            string com = Console.ReadLine();

            Employee Emp1 ;//= new Accenture(id, name, dept, desg, basicSalary);
            if (com.ToLower().Equals("tcs"))
            {
                Emp1 = new TCS(id, name, dept, desg, basicSalary);
            }
            else
            {
                Emp1 = new Accenture(id, name, dept, desg, basicSalary);
            }
            
            
           // Emp1.EmployeePF(basicSalary);
           // Emp1.displayData();
             Console.WriteLine("Press Enter to continue");
            Console.ReadKey();

            while (true)
            {              
                Console.WriteLine("\n\n\nP -----> PF deduction Details");
                Console.WriteLine("L -----> Leave Details");
                Console.WriteLine("G -----> Gratituty Detais");
                Console.WriteLine("E -----> Exist");
                Console.Write("Select any operation mentioned above to continue(P\\L\\G\\E) :");
                string transactionType = Console.ReadLine();

                if (transactionType.ToLower().Equals("p"))
                {
                    Console.WriteLine("******PF details Are ****** ");                  
                    double PF=Emp1.EmployeePF(basicSalary);
                    Console.WriteLine("PF deduction is: {0}",PF);
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                    continue;
                }
                if (transactionType.ToLower().Equals("l"))
                {
                    Console.WriteLine("*****Leave Details Are : *****");
                    Emp1.LeaVeDetails();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                    continue;
                }
                if (transactionType.ToLower().Equals("g"))
                {
                    Console.WriteLine("*****Gratituty Details Are :***** ");
                    Console.WriteLine("As Employer's service period is {0} so as per policy gratituty amt is {1}" , serPeriod,Emp1.gratuityAmount(serPeriod,basicSalary));
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    Emp1.displayData();                   
                    Console.ReadKey();
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
