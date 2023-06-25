using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_13
{
    internal class Student
    {
        private string name;
        private double average;
        private string finalResult;

        public void input()
        {
            Console.Write("Enter the name: ");
            name= Console.ReadLine();
        }

        public void calAverage(int exam,int assigment)
        {
            average = (exam + assigment) / 2;
        }

        public void findFinalResult()
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
