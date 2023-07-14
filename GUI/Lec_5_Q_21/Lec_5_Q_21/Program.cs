using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Customer Name: ");
            string name = Console.ReadLine();

            Bill b = new Bill(name);

            Console.Write("Enter the Unit Consum: ");
            int uc=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Rate: ");
            double rate=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bill Amount: "+b.calBill(uc,rate));

            Console.Write("Enter the Customer Name: ");
            string name2 = Console.ReadLine();

            Console.Write("Enter the Package Amount: ");
            int pa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Additionak Usage: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Rate: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Broadband bb = new Broadband(pa,name2);

            Console.WriteLine("Bill Amount: " + bb.calBill(a, r));

            Console.ReadKey();
        }
    }
}
