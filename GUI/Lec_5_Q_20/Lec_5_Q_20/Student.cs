using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_20
{
    internal class Student
    {
        private string name;
        private string result;

        public string Name { set { name = value; }get { return name; } }
        public string Result { get { return result; } }

        public Student()
        {
            name = "N/A";
            result = "Fail";
        }

        public void finalResult(int e,int cw1,int cw2)
        {
            double avg=(e+cw1+cw2)/3;

            if (avg >= 60)
            {
                result = "Distination";
            }else if(avg >= 40)
            {
                result = "Genaral Pass";
            }
            else
            {
                result = "Fail";
            }
        }

        public void finalResult(int e)
        {
            if (e >= 50)
            {
                result = "Pass";
            }
            else
            {
                result = "Fail";
            }
        }
    }
}
