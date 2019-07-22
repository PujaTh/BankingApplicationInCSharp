using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCSVsAccenture
{
    class Employee:IGovtRules
    {
        public string empid, name, dept, desg;
       // public double basicSalary;
        double basicSalary;
        public double BasicSalary
        {
            get { return basicSalary; }
            set { this.basicSalary = value; }
        }
        public double PF;

        public string Empid
        {
            set { this.empid = value; }
            get { return empid; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string Dept
        {
            set { this.dept = value; }
            get { return dept; }
        }
        public string Desg
        {
            set { this.desg = value; }
            get { return desg; }
        }

        public virtual double EmployeePF(double eg)
        {
            double dl=0.0;
            return dl;
        }

        public virtual void LeaVeDetails()
        { }

        public virtual double gratuityAmount(double serviceCompleted, double basicSalary)
        {
            double dl = 0.0;
            return dl;
        }

        public virtual void displayData()
        {
            /*Console.WriteLine("id of Employee is:" + empid);
            Console.WriteLine("Name of Employee is:" + name);
            Console.WriteLine("Department of Employee is:" + dept);
            Console.WriteLine("total pF deduction of Employee is:{0}",EmployeePF(basicSalary) );*/
        }
    }
}
