using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_13
{
    internal class Student
    {
        public string name;
        public double average;
        public string finalResult;

        public void input()
        {
            Console.Write("Enter the name: ");
            name= Console.ReadLine();
        }

        public void calAverage(int exam,int assigment)
        {
            average = (exam * assigment);
        }

        public void findFinalresult()
        {
            if (average >= 60)
            {
                finalResult = "Pass";
            }
            else
            {
                finalResult = "Fail";
            }
        }

        public void display()
        {
            Console.WriteLine("Final Result: " + finalResult);
        }
    }
}
