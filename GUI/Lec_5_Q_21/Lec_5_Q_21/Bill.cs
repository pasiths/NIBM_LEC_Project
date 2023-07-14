using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_21
{
    internal class Bill
    {
        protected string cus;
        protected double bAmount;

        public virtual double calBill(int unit, double rate)
        {
            bAmount = unit * rate;
            return bAmount;
        }

        public Bill(string cus)
        {
            this.cus = cus;
            bAmount = 0.0;
        }
    }
}
