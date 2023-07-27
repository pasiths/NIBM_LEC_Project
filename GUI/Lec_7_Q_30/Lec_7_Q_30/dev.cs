using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_7_Q_30
{
    internal class dev
    {
        private int weight;
        private string country;
        private string type;
        private int deliveryCost;

        private int rpKG;
        private int add;

        public int Weight { set {  weight = value; } }
        public string Country { set { country = value; } }
        public string Type { set { type = value; } }
        public int DeliveryCost { get { return deliveryCost; } }

        public dev()
        {
            weight = 0;
            country = "";
            type = "";
            deliveryCost = 0;
            rpKG = 0;
            deliveryCost = 0;
        }

        public void cal()
        {
            if (country == "Sri Lanka")
            {
                rpKG = 200;
            }
            else if (country == "India")
            {
                rpKG = 300;
            }
            else if (country == "Other")
            {
                rpKG = 500;
            }

            if (type == "Normal")
            {
                add = 0;
            }
            else if (type == "Express")
            {
                add = 1000;
            }

            deliveryCost = (weight * rpKG) + add;
        }
    }
}
