using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Q_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Withdroval Amount:- ");
            int wa = Convert.ToInt32(Console.ReadLine());

            double tr;

            if (wa > 500000)
            {
                tr = 0.075;
            }
            else if (wa > 200000)
            {
                tr = 0.05;
            }
            else
            {
                tr = 0;
            }

            double ded = wa * tr;
            double fa = wa - ded;

            Console.WriteLine("Deduction Amount:- " + ded);
            Console.WriteLine("Final Amount:- " + fa);

            Console.ReadKey();
        }
    }
}
