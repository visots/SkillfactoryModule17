using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask17_6_6
{
    internal class DefaultAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void InterestCalculate()
        {

            this.Interest = this.Balance * 0.4;
            if (this.Balance < 1000)
                this.Interest -= this.Balance * 0.2;

            if (this.Balance < 50000)
                this.Interest -= this.Balance * 0.4;
        }
    }
}
