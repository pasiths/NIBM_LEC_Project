using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Train Name or Number: ");
            string n=Console.ReadLine();

            Console.Write("Enter the Destination: ");
            string d=Console.ReadLine();

            Console.Write("Enter the Driver Name: ");
            string dn=Console.ReadLine();

            Train t = new Train(n,d,dn);
            t.inputs();

            Console.Write("Enter the Resever Tickets: ");
            int rt=Convert.ToInt32(Console.ReadLine());

            t.purchaseTickets(rt);
            t.incomes();

            Console.ReadKey();
        }
    }
}
