using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAllOperationsProject
{
    class ExceptionMinRequirement:Exception
    {
        public ExceptionMinRequirement(string msg)
            : base(msg)
        { }
    }
}
