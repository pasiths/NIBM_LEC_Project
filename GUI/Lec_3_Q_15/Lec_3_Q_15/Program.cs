using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Name: ");
            string n = Console.ReadLine();

            Console.Write("Enter the Basic Salary: ");
            int bs=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the OT Hours: ");
            int o = Convert.ToInt32(Console.ReadLine());

            Employee emp = new Employee(n, bs);
            emp.OTH(o);
            emp.calFinalSalary();

            Console.WriteLine("Final Salary: "+emp.returnFinalSalary());

            Console.ReadKey();
        }
    }
}
