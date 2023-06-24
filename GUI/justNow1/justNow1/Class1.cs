using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justNow1
{
    internal class Class1
    {
        private string name;
        private double avg;
        private string finalResult;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /*
        public double Average
        {
            get { return avg; }
            set { avg = value; }
        }
        */
        public string FinalResult
        {
            get { return finalResult; }
            //set { finalResult = value; }
        }

        public Class1()
        {
            name = "N/A";
            avg=0.0;
            finalResult = "F";
        }

        public void cal(int exam,int assignment)
        {
            avg=(exam + assignment)/2;
        }

        public void FR()
        {
            if (avg >= 60)
            {
                finalResult = "D";
            }
            else if (avg >= 40)
            {
                finalResult = "GP";
            }
            else
            {
                finalResult = "F";
            }
        }
    }
}
