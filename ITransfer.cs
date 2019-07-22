using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAllOperationsProject
{
    interface ITransfer
    {
        void transferAmount(AbsAccount to, double amt);
    }
}
