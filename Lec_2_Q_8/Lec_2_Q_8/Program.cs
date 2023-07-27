using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Q_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int wa = 0;
            Console.Write("Enter the Withdraw Amount:- ");
            wa = Convert.ToInt32(Console.ReadLine());

            int n_5000 = 0;
            int n_1000 = 0;
            int n_500 = 0;
            int n_100 = 0;

            if (wa % 100 == 0)
            {
                while (wa != 0)
                {
                    if (wa >= 5000)
                    {
                        n_5000 = wa / 5000;
                        wa = wa - (n_5000 * 5000);
                    }
                    else if (wa >= 1000)
                    {
                        n_1000 = wa / 1000;
                        wa = wa - (n_1000 * 1000);
                    }
                    else if (wa >= 500)
                    {
                        n_500 = wa / 500;
                        wa = wa - (n_500 * 500);
                    }
                    else
                    {
                        n_100 = wa / 100;
                        wa = wa - (n_100 * 100);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Amount, Please Try Again!!!");
            }

            //Console.WriteLine("WithDrawal Amount:- " + wa);
            Console.WriteLine();
            Console.WriteLine("5000 Notes:- " + n_5000);
            Console.WriteLine();
            Console.WriteLine("1000 Notes:- " + n_1000);
            Console.WriteLine();
            Console.WriteLine("500 Notes:- " + n_500);
            Console.WriteLine();
            Console.WriteLine("100 Notes:- " + n_100);

            Console.ReadKey();
        }
    }
}
