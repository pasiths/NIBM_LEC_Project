using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_8_Q_31
{
    public partial class FrmBillMaker : Form
    {
        Bill bl;
        public FrmBillMaker()
        {
            InitializeComponent();
            bl = new Bill();
            TxtName.Focus();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bl.Name=TxtName.Text;
                TxtPrice.Focus();
            }
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            bl.UnitPrice = Convert.ToInt32(TxtPrice.Text);
            //bl.DiscountRate = Convert.ToDouble(TxtDisRate.Text);

            bl.calDis();

            TxtDisPrice.Text = bl.DiscountPrice.ToString();
        }

        private void TxtDisRate_TextChanged(object sender, EventArgs e)
        {
            bl.UnitPrice = Convert.ToInt32(TxtPrice.Text);
            bl.DiscountRate=Convert.ToDouble(TxtDisRate.Text);

            bl.calDis();

            TxtDisPrice.Text=bl.DiscountPrice.ToString();
        }

        private void TxtQunSolved_TextChanged(object sender, EventArgs e)
        {
            bl.QuntitySolved = Convert.ToInt32(TxtQunSolved.Text);

            bl.calDis();
            bl.calSalesAmount();

            TxtSalAmount.Text=bl.SalesAmount.ToString();
        }
    }
}