using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4_Q_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Broadband bb=new Broadband();

            Console.Write("Enter the Bill Number: ");
            int bn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Customer Name: ");
            string cn = Console.ReadLine();

            Console.Write("Enter the Additional Usage: ");
            int au=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Package Amount: ");
            int pa=Convert.ToInt32(Console.ReadLine());

            bb.inputs(bn, cn);
            bb.AddUsage = au;
            bb.PackAmount = pa;
            bb.cal();

            Console.WriteLine("Bill Amount: " + bb.output());

            Console.ReadKey();
        }
    }
}
