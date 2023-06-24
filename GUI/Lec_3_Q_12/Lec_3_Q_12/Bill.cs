using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_3_Q_12
{
    internal class Bill
    {
        public string name;
        public int unitPrice;
        public int quantity;

        public void inputs()
        {
            Console.Write("Enter the Name: ");
            name= Console.ReadLine();

            Console.Write("Enter the Unit Price: ");
            unitPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Quantity in Hand: ");
            quantity = Convert.ToInt32(Console.ReadLine());
        }

        public void salesAmount()
        {
            Console.Write("Enter the Sales: ");
            int sales = Convert.ToInt32(Console.ReadLine());

            int salesAmount = unitPrice * sales;

            Console.WriteLine("Sales Amount: " + salesAmount);

            quantity = quantity - sales;
        }

        public void purchaseQuantity()
        {
            Console.Write("Enter the Purchase Quantity: ");
            int purchase = Convert.ToInt32(Console.ReadLine());

            quantity += purchase;
        }

        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Unit Price: " + unitPrice);
            Console.WriteLine("Quantity in Hand: " + quantity);
        }
    }
}
