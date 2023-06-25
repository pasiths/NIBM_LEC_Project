using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_15
{
    internal class Employee
    {
        private string name;
        private int basicSalary;
        private int oth;
        private int finalSalary;

        public Employee(string n, int bs)
        {
            name = n;
            basicSalary = bs;
            oth = 0;
            finalSalary = 0;
        }

        public void OTH(int o)
        {
            oth = o;
        }

        public void calFinalSalary()
        {

            finalSalary = basicSalary + (oth * 2000);
        }

        public int returnFinalSalary()
        {
            return finalSalary;
        }
    }
}