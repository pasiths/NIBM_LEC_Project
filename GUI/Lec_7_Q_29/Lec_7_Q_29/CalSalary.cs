using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_7_Q_29
{
    internal class CalSalary
    {
        private int bs;
        private int ot;
        private int fs;

        public int BS
        {
            set { bs = value; }
        }

        public int OT
        {
            set { ot = value; }
        }

        public int FS 
        { 
            get { return fs; } 
        }

        public void cal()
        {
            fs = bs + (ot * 1500);
        }
    }
}
