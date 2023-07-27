using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_7_Q_30
{
    public partial class Form1 : Form
    {
        dev d;
        public Form1()
        {
            InitializeComponent();
            d=new dev();
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            d.Weight = Convert.ToInt32(TxtWOP.Text);
            d.Country = CmbCTD.SelectedItem.ToString();
            if(RdbNormal.Checked==true)
            {
                d.Type=RdbNormal.Text;
            }else if(RdbExpress.Checked == true){
                d.Type= RdbExpress.Text;
            }

            d.cal();

            TxtDC.Text=d.DeliveryCost.ToString();
        }
    }
}
