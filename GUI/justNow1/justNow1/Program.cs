using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justNow1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 cl1=new Class1();

            Console.Write("Enter the Name: ");
            cl1.Name=Console.ReadLine();

            Console.Write("Enter the Exam Marks: ");
            int exam =Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Assigment: ");
            int assigment = Convert.ToInt32(Console.ReadLine());

            cl1.cal(exam,assigment);
            cl1.FR();

            //string r = cl1.FinalResult;
            Console.WriteLine("Final Result: "+ cl1.FinalResult);

            Console.ReadKey();
        }
    }
}
