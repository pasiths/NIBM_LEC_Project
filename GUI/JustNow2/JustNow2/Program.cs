using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustNow2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vs= new Vehicle();

            Console.Write("Enter the vehicle Number: ");
            vs.Number=Console.ReadLine();

            Console.Write("Enter the Parking Slot: ");
            vs.Prack_Slot=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Number of Mins: ");
            vs.NOM=Convert.ToInt32(Console.ReadLine());

            vs.cal();

            Console.WriteLine("Fee:" + vs.Fee);

            Console.ReadKey();
        }
    }
}
