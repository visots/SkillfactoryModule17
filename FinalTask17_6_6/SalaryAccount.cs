using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask17_6_6
{
    internal class SalaryAccount : IAccount
    {
        public double Balance { get ; set ; }
        public double Interest { get ; set ; }

        public void InterestCalculate()
        {
            this.Interest = this.Balance * 0.5;
        }
    }
}
