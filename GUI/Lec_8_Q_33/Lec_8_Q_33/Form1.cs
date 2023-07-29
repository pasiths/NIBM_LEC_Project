using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_8_Q_33
{
    public partial class FrmDelSys : Form
    {
        DeliveryCost dc;
        public FrmDelSys()
        {
            InitializeComponent();
            dc=new DeliveryCost();
            country();
        }

        public void country()
        {
            string[] country = { "SriLanka", "Other Country" };
            for(int c=0; c<country.Length; c++)
            {
                CmbCon.Items.Add(country[c]);
            }
        }

        private void BtnCalCost_Click(object sender, EventArgs e)
        {
            if(TxtName.Text=="" || TxtName.Text==null)
            {
                MessageBox.Show("Customer Name Can't Be Empty");
                return;
            }

            if(TxtAdd.Text == "" || TxtAdd.Text == null)
            {
                MessageBox.Show("Customer Address Can't Be Empty");
                return;
            }

            if (TxtAdd.Text.Length < 4)
            {
                MessageBox.Show("Address should be 4 or abouve");
                return;
            }

            Double WP;
            if(Double.TryParse(TxtWP.Text, out WP) == false)
            {
                MessageBox.Show("Weight of Package should be numberical");
                return;
            }

            if(WP<=0.0)
            {
                MessageBox.Show("Weight of Package cant be 0");
                return;
            }

            if (CmbCon.SelectedIndex == -1)
            {
                MessageBox.Show("Country Should be Selected");
                return;
            }

            dc.Name=TxtName.Text;
            dc.Address = TxtAdd.Text;
            dc.Country=CmbCon.SelectedItem.ToString();
            dc.Wp=WP;
            
            dc.calCost();

            TxtCost.Text=dc.Cost.ToString();
        }
    }
}
