using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Q_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int max = 0;
            int min = 0;
            for (int c = 0; c < 10; c++)
            {
                Console.Write("Enter the Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (c == 0)
                {
                    max = num;
                    min = num;
                }
                else
                {
                    if (max < num)
                    {
                        max = num;
                    }
                    if (min > num)
                    {
                        min = num;
                    }
                }
            }

            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);

            Console.ReadKey();
        }
    }
}
