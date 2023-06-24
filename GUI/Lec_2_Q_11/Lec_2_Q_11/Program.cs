using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_Q_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string tn;
            int[] com = new int[10];
            int stot = 0;

            Console.Write("Enter the Train Number or Name: ");
            tn = Console.ReadLine();

            for(int c = 0; c < 10; c++)
            {
                Console.Write("Enter the Count of Seats: ");
                com[c] = Convert.ToInt32(Console.ReadLine());
            }
            for (int c = 0; c < 10; c++)
            {
                stot += com[c];
            }

            int ei = stot * 350;

            Console.WriteLine("Expected Income: " + ei);

            Console.ReadKey();
        }
    }
}
