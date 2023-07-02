using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4_Q_18
{
    internal class Broadband:Bill
    {
        private int packAmount;
        private int addUsage;

        public int PackAmount { get { return packAmount; } set {  packAmount = value; } }
        public int AddUsage { get {  return addUsage; } set {  addUsage = value; } }

        public void cal()
        {
            finalAmount=packAmount+(addUsage*120);
        }
    }
}
