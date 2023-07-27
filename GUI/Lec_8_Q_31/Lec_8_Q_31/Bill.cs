using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_8_Q_31
{
    internal class Bill
    {
        private string name;
        private int up;
        private double dr;
        private double dp;
        private int qs;
        private double sa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int UnitPrice
        {
            get { return up; }
            set { up = value; }
        }
        public double DiscountRate
        {
            get { return dr; }
            set { dr = value; }
        }
        public double DiscountPrice
        {
            get { return dp; }
            set { dp = value; }
        }
        public int QuntitySolved
        {
            get { return qs; }
            set { qs = value; }
        }
        public double SalesAmount
        {
            get { return sa; }
            set { sa = value; }
        }

        public void calDis()
        {
            dp = up * dr;
        }

        public void calSalesAmount()
        {
            sa = (up-dp)*qs;
        }
    }
}