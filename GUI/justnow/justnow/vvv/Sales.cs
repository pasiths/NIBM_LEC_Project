using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justnow
{
    internal class Sales
    {
        private string name;
        private double up;
        private double dr;
        private double dp;
        private int q;
        private double sa;

        public string Name { get => name; set => name = value; }
        public double Up { get => up; set => up = value; }
        public double Dr { get => dr; set => dr = value; }
        public double Dp { get => dp; set => dp = value; }
        public int Q { get => q; set => q = value; }
        public double Sa { get => sa; }
        public Sales()
        {
            name = "";
            up = 0.0;
            dr = 0.0;
            dp= 0.0;
            q = 0;
            sa = 0.0;
        }
        public void calDis ()
        {
            dp = up * dr;
        }
        public void calSA()
        {
            sa = (up - dp) * q;
        }
    }
}
