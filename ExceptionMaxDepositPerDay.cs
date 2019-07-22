using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAllOperationsProject
{
    class ExceptionMaxDepositPerDay:Exception
    {
        public ExceptionMaxDepositPerDay(string msg)
            : base(msg)
        { }
    }
}
