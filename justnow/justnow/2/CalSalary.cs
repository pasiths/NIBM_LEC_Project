using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justnow._2
{
    internal class CalSalary
    {
        private int bs;
        private int ot;
        private int fs;

        public int Bs { get => bs; set => bs = value; }
        public int Ot { get => ot; set => ot = value; }
        public int Fs { get => fs; set => fs = value; }
        public CalSalary()
        {
            Bs = 0;
            Ot = 0;
            Fs = 0;
        }
        public void cal()
        {
            fs = bs + (ot*1000);
        }
    }
}
