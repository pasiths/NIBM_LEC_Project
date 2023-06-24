using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JustNow2
{
    internal class Vehicle
    {
        private string number;
        private int prack_slot;
        private int nom;
        private int fee;

        public Vehicle()
        {
            number = "N/A";
            prack_slot = 0;
            nom = 0;
        }

        public string Number {
            get { return number; }
            set { number = value; }
        }

        public int Prack_Slot
        {
            get { return prack_slot; }
            set { prack_slot = value; }
        }

        public int NOM
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Fee
        {
            get { return fee; }
        }

        public void cal()
        {
            int rpm;
            if (nom > 180)
            {
                rpm = 3;
            }
            else if (nom > 90)
            {
                rpm = 2;
            }
            else
            {
                rpm = 1;
            }

            fee = rpm * nom;
        }
    }
}
