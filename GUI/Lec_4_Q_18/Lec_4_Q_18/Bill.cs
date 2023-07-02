using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4_Q_18
{
    internal class Bill
    {
        protected int num;
        protected string name;
        protected double finalAmount;

        public void inputs(int bn,string cn)
        {
            num = bn;
            name = cn;
        }

        public double output()
        {
            return finalAmount;
        }
    }
}
