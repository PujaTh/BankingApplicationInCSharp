using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCSVsAccenture
{
    class Accenture:Employee
    {
    double basicSalary;
        public  double BasicSalary
            {
            get { return basicSalary; }
            set { this.basicSalary = value; }
            }
       
        public Accenture(string _empid, string _name, string _dept, string _desg, double _basicSalary)
            {
            //using set{}
            Empid = _empid;
            Name = _name;
            Dept = _dept;
            BasicSalary = _basicSalary;
            }
        
        public override  double EmployeePF(double basicSalary)
        {
            Console.WriteLine("Fund Deduction for Accenture Employee is as follow");
            double employerContri = (12 * basicSalary) / 100;
            double employeeContri = (12 * basicSalary) / 100;
            PF = employerContri + employeeContri;
            return PF;
        }

        public override void displayData()
        {
            Console.WriteLine("id of Employee is:" + empid);
            Console.WriteLine("Name of Employee is:" + name);
            Console.WriteLine("Department of Employee is:" + dept);
            Console.WriteLine("total pF deduction of Employee is:{0}", PF);
        }

        public override void LeaVeDetails()
        {
        Console.WriteLine("Leaves details for Accenture Employee are as follow");
        Console.WriteLine("2 day of Casual Leave per month");
        Console.WriteLine("5 days of Sick Leave per year");
        Console.WriteLine("5 days of Previlage Leave per year");
        }

        public override double gratuityAmount(double serviceCompleted, double basicSalary)
        {
            Console.WriteLine("Sorry Gratuity policy ..we dont have!!!");
            double dl = 0.0;
            return dl;
        }
    }
}
