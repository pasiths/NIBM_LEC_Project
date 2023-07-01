using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4_Q_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Sutudent Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the Marks of Exam: ");
            int exam=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Marks of Assigment: ");
            int a=Convert.ToInt32(Console.ReadLine());

            Student st = new Student();
            st.studentName = name;
            st.calAvg(exam, a);
            st.findFinalResult();

            Console.WriteLine("Final Result: " + st.result);

            Console.ReadKey();
        }
    }
}
