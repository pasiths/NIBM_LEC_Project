using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_8_Q_32
{
    public class Salary
    {
        private string name;
        private int bs;
        private int ot;
        private int fs;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Bs
        {
            get { return bs; }
            set { bs = value; }
        }

        public int Ot
        {
            get { return ot; }
            set { ot = value; }
        }

        public int Fs
        {
            get { return fs; }
            set { fs = value; }
        }

        public Salary()
        {
            name = "";
            bs = 0;
            ot = 0;
            fs = 0;
        }

        public void calSalary()
        {
            fs = bs + (ot * 1000);
        }
    }
}
