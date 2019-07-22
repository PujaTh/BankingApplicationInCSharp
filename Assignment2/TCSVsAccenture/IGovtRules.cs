using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCSVsAccenture
{
    interface IGovtRules
    {
        string Empid
        {
            set;
            get;
        }
        string Name
        {
            set;
            get;
        }
        string Dept
        {
            set;
            get;
        }
        string Desg
        {
            set;
            get;
        }

        void displayData();
        double EmployeePF(double eg);
        void LeaVeDetails();
        double gratuityAmount(double serviceCompleted,double basicSalary);
    }
}
