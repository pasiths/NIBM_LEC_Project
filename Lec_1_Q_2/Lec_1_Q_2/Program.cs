using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_1_Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 95;
            int num2 = 20;

            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            double div = num1 / num2;
            double rem = num1 % num2;

            Console.WriteLine("Additon:- " + add);
            Console.WriteLine("Substraction:- " + sub);
            Console.WriteLine("Multiplication:- " + mul);
            Console.WriteLine("Division:- " + div);
            Console.WriteLine("Remainder:- " + rem);

            Console.ReadKey();
        }
    }
}
