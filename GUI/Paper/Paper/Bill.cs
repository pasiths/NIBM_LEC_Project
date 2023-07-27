using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper
{
    internal class Bill
    {
        private double price;
        private double q;
        private double dr;
        private double d;
        private double b;
        private double f;

        public Bill()
        {
            this.price = 0.0;
            this.q = 0.0;
            this.d = 0.0;
            this.b = 1.0;
            this.f = 0.0;
        }

        public double Price { get => price; set => price = value; }
        public double Q { get => q; set => q = value; }
        public double DR { get => dr; set => dr = value; }
        public double F { get => f; set => f = value; }

        public void calBill()
        {
            b = price * q;
        }
        public void calDis()
        {
            d = b * dr;
        }
        public void calF()
        {
            f = b - d;
        }
    }
}
