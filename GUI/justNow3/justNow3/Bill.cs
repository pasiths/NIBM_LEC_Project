using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace justNow3
{
    internal class Bill
    {
        protected string billNumber;
        protected string cusName;
        protected double billAmount;

        /*
        public Bill()
        {
            billNumber = "N/A";
            cusName = "N/A";
            billAmount = 0;
        }

        public Bill(string bn,string cn)
        {
            billNumber = bn;
            cusName = cn;
        }
        */

        public void input(string bn,string cn)
        {
            billNumber = bn;
            cusName = cn;
        }

        public double BillAmount()
        {
            return billAmount;
        }
    }
}
