using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_14
{
    internal class Train
    {
        private string name;
        private string destination;
        private string driverName;
        private int[] apartment = new int[10];
        private int totSeats;
        private int reserveTickets;


        public Train(string n, string des, string dn)
        {
            name = n;
            destination = des;
            driverName = dn;
        }

        public void inputs()
        {
            for(int c=0;c<apartment.Length;c++)
            {
                Console.Write("Enter the Capasity of Apartment: ");
                apartment[c]=Convert.ToInt32(Console.ReadLine());
            }
            for (int c = 0; c < apartment.Length; c++)
            {
                totSeats += apartment[c];
            }
        }

        public void purchaseTickets(int rt)
        {
            reserveTickets = rt;
            int available = totSeats - reserveTickets;
            Console.WriteLine("Available Seats: " + available);
        }

        public void incomes()
        {
            int income = reserveTickets * 400;
            Console.WriteLine("Expected Income: " + income);
        }
    }
}
