using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_21
{
    internal class Broadband:Bill
    {
        private double packAmount;

        public Broadband(double pa,string n) : base(n)
        {
            packAmount = pa;
        }

        public override double calBill(int add, double rate)
        {
            bAmount=packAmount+(rate*add);
            return bAmount;
        }
    }
}
