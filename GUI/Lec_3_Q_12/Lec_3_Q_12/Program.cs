using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bill bl = new Bill();
            bl.inputs();
            bl.salesAmount();
            bl.display();
            bl.purchaseQuantity();
            bl.display();

            Console.ReadKey();
        }
    }
}
