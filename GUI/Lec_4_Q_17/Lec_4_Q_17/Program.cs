using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4_Q_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();

            Console.Write("Enter the Vehicle Number: ");
            v.vehicleNumber = Console.ReadLine();

            Console.Write("Enter the Parking Slot: ");
            v.parkingSlot= Console.ReadLine();

            Console.Write("Enter the Paking time: ");
            v.numberOfMinites = Convert.ToInt32(Console.ReadLine());

            v.cal();

            Console.WriteLine("Fee: " + v.finalFee);

            Console.ReadKey();
        }
    }
}
