using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_22
{
    internal class Employee
    {
        protected string name;
        protected int salary;
        protected int finalSalary;

        public Employee()
        {
            name = "N/A";
            salary = 0;
        }

        public Employee(string n)
        {
            name = n;
            salary = 0;
        }

        public int calSalary(int salary,int ot)
        {
            finalSalary = salary + (ot * 2500);
            return finalSalary;
        }
    }
}
