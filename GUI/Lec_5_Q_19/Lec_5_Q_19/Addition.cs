using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5_Q_19
{
    internal class Addition
    {
        public void Add()
        {
            Console.Write("Enter the number one: ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number two: ");
            int num2=Convert.ToInt32(Console.ReadLine());

            int add = num1 + num2;
        }

        public void Add(int n1,int n2)
        {
            int add=n1+n2;
        }

        public void Add(string s1,string s2)
        {
            string add=s1+s2;
        }

        public void Add(double n1,double n2)
        {
            double add=n1+n2;
        }

        public void Add(string s1,double n1)
        {
            string add = s1 + n1;
        }
    }
}
