using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            Console.Write("Enter the student name: ");
            st.Name = Console.ReadLine();

            Console.Write("Enter the Student Type: ");
            string stype= Console.ReadLine();

            if (stype == "Undergraduate")
            {
                Console.Write("Enter the exam marks: ");
                int exam=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Marks of Course Work_1: ");
                int cw1=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Marks of Course work_2: ");
                int cw2=Convert.ToInt32(Console.ReadLine());

                st.finalResult(exam,cw1,cw2);
            }
            else if(stype =="Certificate")
            {
                Console.Write("Enter the marks of exam: ");
                int exam= Convert.ToInt32(Console.ReadLine());

                st.finalResult(exam);
            }
            else
            {
                Console.WriteLine("Invalid Student Type");
            }

            Console.WriteLine("Final Result: " + st.Result);

            Console.ReadKey();
        }
    }
}
