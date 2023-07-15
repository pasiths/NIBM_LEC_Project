using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_22
{
    internal class ContractEmployee:Employee
    {
        public ContractEmployee(string name) : base(name)
        {
            name = name.Trim();
        }

        public int calSalary(int salary, int days)
        {
            finalSalary = salary + days;
            return finalSalary;
        }
    }
}
