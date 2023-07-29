using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_8_Q_33
{
    public class DeliveryCost
    {
        private string name;
        private string address;
        private string country;
        private double wp;
        private double cost;

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Country { get { return country; } set { country = value; } }
        public double Wp { get { return wp; } set { wp = value; } }
        public double Cost { get { return cost; } set { cost = value; } }

        public DeliveryCost()
        {
            name = "";
            address = "";
            country = "";
            wp= 0.0;
            cost = 0.0;
        }

        public void calCost()
        {
            int rate;

            if (country== "SriLanka")
            {
                rate = 250;
            }
            else
            {
                rate = 350;
            }

            cost=wp*rate;
        }
    }
}
