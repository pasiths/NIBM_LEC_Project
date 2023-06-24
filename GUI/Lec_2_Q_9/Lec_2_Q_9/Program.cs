using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Q_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int tot = 0;
            int fc = 0;

            do
            {
                fc = 0;
                Console.Write("Enter a Number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int c = 1; c <= num; c++)
                {
                    if (num % c == 0)
                    {

                        fc++;
                    }
                }
                tot += num;
                i++;
            } while (fc > 2);

            Console.WriteLine("Count of Inputs: " + i);
            Console.WriteLine("Total of the Inputs: " + tot);

            Console.ReadKey();
        }
    }
}
