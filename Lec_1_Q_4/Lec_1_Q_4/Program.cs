using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_1_Q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the customer name:- ");
            string name = Console.ReadLine();

            Console.Write("Enter the traveled in KM:- ");
            double km = Convert.ToDouble(Console.ReadLine());

            int rpKM;

            if (km > 2)
            {
                rpKM = 80;
            }
            else
            {
                rpKM = 60;
            }

            double fa = km * rpKM;

            Console.WriteLine("Final Amount:- " + fa);

            Console.ReadKey();
        }
    }
}
