using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tot = 0;

            for (int i = 20; i < 50; i++)
            {
                tot += i;
            }

            Console.WriteLine("Total:- " + tot);

            Console.ReadKey();
        }
    }
}
