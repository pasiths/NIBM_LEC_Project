using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4_Q_17
{
    internal class Vehicle
    {
        private string number;
        private string slot;
        private int nom;
        private int fee;

        public string vehicleNumber
        {
            get { return number; }
            set { number = value; }
        }

        public string parkingSlot
        {
            get { return slot; }
            set { slot = value; }
        }

        public int numberOfMinites
        {
            get { return nom; }
            set { nom = value; }
        }

        public int finalFee
        {
            get { return fee; }
        }

        public Vehicle()
        {
            number = "N/A";
            slot = "N/A";
            nom = 0;
            fee = 0;
        }

        public void cal()
        {
            int rpm;
            if (nom > 180)
            {
                rpm = 3;
            }
            else if(nom>90)
            {
                rpm = 2;
            }
            else
            {
                rpm = 1;
            }

            fee = nom * rpm;
        }
    }
}
