using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the Employee Salary: ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Number of OT Hours: ");
            int ot = Convert.ToInt32(Console.ReadLine());

            Employee em = new Employee(name);

            Console.WriteLine("Final Salary: "+em.calSalary(s, ot));

            Console.WriteLine('\n');

            Console.Write("Enter the Contract Employee Name: ");
            name= Console.ReadLine();

            Console.Write("Enter the Contract Employee Salary: ");
            s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Number of Days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            ContractEmployee ce=new ContractEmployee(name);

            Console.WriteLine("Final Salary: " + ce.calSalary(s, days));

            Console.ReadKey();
        }
    }
}
