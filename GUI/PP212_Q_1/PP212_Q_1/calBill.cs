using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP212_Q_1
{
    public  class calBill
    {
        private string dataType;
        private int day;
        private int night;
        private int ba;

        public string DataType { get => dataType; set => dataType = value; }
        public int Day { get => day; set => day = value; }
        public int Night { get => night; set => night = value; }
        public int Ba { get => ba; set => ba = value; }

        public calBill()
        {
            this.dataType = "";
            this.day = 0;
            this.night = 0;
            this.ba = 0;
        }

        public void cal()
        {
            int dayPrice =0, nightPrice=0;

            if(dataType== "Double Blast")
            {
                if (day > 50)
                {
                    dayPrice = (50 * 400) + ((day - 50) * 10);
                }
                else
                {
                    dayPrice = day * 400;

                }
                if (night > 10)
                {
                    nightPrice=(10*200)+((night - 10) * 20);
                }
                else
                {
                    nightPrice = night * 200;
                }
                ba = 200 + nightPrice + dayPrice;

                if (ba < 1000)
                {
                    ba = ba + 250;
                }
                else
                {
                    ba =ba + 350;
                }
            }
            else
            {
                if (day > 10)
                {
                    dayPrice=(10*200)+((day - 10) * 20);
                }
                else
                {
                    dayPrice= day * 200;
                }
                if (night > 100)
                {
                    nightPrice=(100*600)+((night - 100) * 10);
                }
                else
                {
                    nightPrice = night * 600;
                }
                ba = 400 + dayPrice + nightPrice;
                
                if (ba < 1500)
                {
                    ba =ba + 350;
                }
                else
                {
                    ba =ba + 450;
                }
            }
        }
    }
}
