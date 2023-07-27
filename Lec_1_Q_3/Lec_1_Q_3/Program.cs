using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_1_Q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Customer name:- ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of tourists:- ");
            int not = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of days:- ");
            int nod = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Rate Per day:- ");
            double rpd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Reservation Amount:- " + (not * nod * rpd));

            Console.ReadKey();
        }
    }
}
