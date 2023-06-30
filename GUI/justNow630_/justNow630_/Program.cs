using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justNow630_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 st = new Class1();
            Console.WriteLine("Enter Stidnt name: ");
            st.studentName=Console.ReadLine();

            Console.WriteLine("Enter Student type: ");
            string type = Console.ReadLine();

            if (type=="under gradute")
            {
                Console.WriteLine("Enter CW1 Marks: ");
                int cw1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter CW2 Marks: ");
                int cw2=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Exam Marks: ");
                int exam = Convert.ToInt32(Console.ReadLine());

                st.findResult(exam, cw1, cw2);
            }
            else
            {
                Console.WriteLine("Enter Exam Marks: ");
                int exam=Convert.ToInt32(Console.ReadLine());
                st.findResult(exam);
            }
            Console.WriteLine("Final Result: " + st.studentName);

            Console.ReadKey();
        }
    }
}
