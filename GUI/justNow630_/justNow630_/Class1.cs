using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justNow630_
{
    internal class Class1
    {
        private string name;
        private string fr;
        public string studentName
        {
            get { return name; }
            set { name = value; }
        }
        public string finalResult
        {
            get { return fr; }
            set { fr = value; }
        }

        public Class1()
        {
            name = "";
            finalResult = "Fail";
        }


        public void findResult(int exam,int cw1,int cw2)
        {
            double avg=(exam+cw1+cw2)/3;
            if (avg >= 60)
            {
                finalResult = "D";
            }
            else if(avg >= 40)
            {
                finalResult = "G P";
            }
            else
            {
                finalResult = "F";
            }
        }

        public void findResult(int exam)
        {
            if(exam >= 50)
            {
                finalResult = "Pass";
            }
            else
            {
                finalResult = "Fail";
            }
        }
    }
}
