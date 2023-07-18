using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_7_Q_28
{
    internal class BillCal
    {
        private string c_name;
        private int ptt;
        private int stt;
        private double ba;

        public string cus_name { 
            set { c_name = value; }
            get { return c_name; } 
        }

        public int PTT
        {
            set { ptt = value; }
            get { return ptt; }
        }

        public int STT
        {
            set { stt = value; }
            get { return stt; }
        }

        public double BA
        {
            get { return ba; }
        }

        public void cal()
        {
            ba = (stt * 2.50) + (ptt * 3.0);
        }
    }
}
