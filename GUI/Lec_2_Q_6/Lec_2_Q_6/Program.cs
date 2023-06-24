using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Q_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Customer Name:- ");
            string name = Console.ReadLine();

            Console.Write("Enter the Department:- ");
            string dep = Console.ReadLine();

            Console.Write("Enter the OTH:- ");
            int oth = Convert.ToInt32(Console.ReadLine());

            int bs;
            int rpoth;

            switch (dep)
            {
                case "Sales":
                    bs = 30000;
                    rpoth = 3000;
                    break;

                case "HR":
                    bs = 40000;
                    rpoth = 2500;
                    break;

                case "Finace":
                    bs = 60000;
                    rpoth = 1500;
                    break;

                default:
                    bs = 50000;
                    rpoth = 4000;
                    break;
            }

            int fs = bs + (rpoth * oth);

            Console.WriteLine("Final salary:- " + fs);

            Console.ReadKey();
        }
    }
}
