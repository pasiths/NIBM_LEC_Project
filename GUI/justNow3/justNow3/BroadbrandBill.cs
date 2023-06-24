using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justNow3
{
    internal class BroadbrandBill:Bill
    {
        private int packAmount;
        private int addUseage;

        public BroadbrandBill()
        {
            packAmount = 0;
            addUseage = 0;
        }
        public int PakAmount
        {
            get { return packAmount; }
            set { packAmount = value; }
        }

        public int AddUseage
        {
            get { return addUseage; }
            set { addUseage = value; }
        }

        public void cal()
        {
            billAmount = packAmount + (addUseage * 120);
            //Console.WriteLine("Final Bill: " + billAmount);

        }
    }
}
