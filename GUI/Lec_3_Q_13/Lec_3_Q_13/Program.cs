using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.input();

            Console.Write("Enter the Marks of Exam: ");
            int exam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Marks of Assigment: ");
            int assigmnet= Convert.ToInt32(Console.ReadLine());

            st.calAverage(exam, assigmnet);
            st.findFinalResult();
            st.display();

            Console.ReadKey();
        }
    }
}
