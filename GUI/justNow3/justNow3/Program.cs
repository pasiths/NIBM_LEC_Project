using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justNow3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Bill Number: ");
            string bnum=Console.ReadLine();

            Console.Write("Enter the Customer name: ");
            string cname=Console.ReadLine();

            Bill bl = new Bill();
            BroadbrandBill bbl = new BroadbrandBill();

            bl.input(bnum, cname);

            Console.Write("Enter the Additional Usage: ");
            bbl.AddUseage=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Package Amount: ");
            bbl.PakAmount=Convert.ToInt32(Console.ReadLine());


            bbl.cal();


            Console.WriteLine("Final Bill: " + bbl.BillAmount());

            Console.ReadKey();
        }
    }
}
