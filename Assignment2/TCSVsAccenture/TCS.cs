using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCSVsAccenture
{
    class TCS:Employee
    {
        double basicSalary;
        public double BasicSalary
        {
            get { return basicSalary; }
            set { this.basicSalary = value; }
        }

        public TCS(string _empid, string _name, string _dept, string _desg, double _basicSalary)
            {
            //using set{}
            Empid = _empid;
            Name = _name;
            Dept = _dept;
            BasicSalary = _basicSalary;
            }

        public override double EmployeePF(double basicSalary)
        {
            Console.WriteLine("Fund Deduction for TCS Employee is as follow");
            double employerContri = (8.33 * basicSalary) / 100;
            double employeeContri = (12 * basicSalary) / 100;
            double pensionFunds = ( 3.67 * basicSalary) / 100;
            PF = employerContri + employeeContri+pensionFunds;
            return PF;
        }

        public override void displayData()
        {
            Console.WriteLine("id of Employee is:" + empid);
            Console.WriteLine("Name of Employee is:" + name);
            Console.WriteLine("Department of Employee is:" + dept);
            Console.WriteLine("total funds deduction for Employee is:{0}", PF);
        }

        public override  void LeaVeDetails()
        {
            Console.WriteLine("Leaves details for TCS Employee are as follow");
            Console.WriteLine("1 day of Casual Leave per month");
            Console.WriteLine("12 days of Sick Leave per year");
            Console.WriteLine("10 days of Previlage Leave per year");
        }

        public override double gratuityAmount(double serviceCompleted, double basicSalary)
        {
            Console.WriteLine("****Gratuity policy for TCS Employee****");
            double GA = 0.0;
            if(serviceCompleted > 5) 
            {
                GA=basicSalary;
            }
            if (serviceCompleted>10) 
            {
            GA=2*basicSalary;
            }
            if( serviceCompleted>20) 
            {
            GA=3*basicSalary;
            }
            if (serviceCompleted < 5)
            {
                GA = 0.0;
            }
            return GA;
        }
    }
}
