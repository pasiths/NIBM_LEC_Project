using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4_Q_16
{
    internal class Student
    {
        private string name;
        private double avg;
        private string finalResult;

        public string studentName
        {
            get { return name; }
            set { name = value; }
        }

        public string result
        {
            get { return finalResult; }
        }

        public Student()
        {
            name = "N/A";
            avg = 0.0;
            finalResult = "F";
        }

        public void calAvg(int exam,int assigment)
        {
            avg = (exam + assigment) / 2;
        }

        public void findFinalResult()
        {
            if (avg >= 60)
            {
                finalResult = "Distination";
            }
            else if(avg >= 40)
            {
                finalResult = "General Pass";
            }
            else
            {
                finalResult = "Fail";
            }
        }
    }
}
