using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            addition.Add();
            addition.Add(1, 2);
            addition.Add("NI", "BM");
            addition.Add(1.00, 2.00);
            addition.Add("NI", 9.00);

            Console.ReadKey();
        }
    }
}
