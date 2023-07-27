using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justnow
{
    public partial class Form1 : Form
    {
        Sales sales;
        public Form1()
        {
            InitializeComponent();
            sales = new Sales();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //Read value into item name
                sales.Name=txtName.Text;
                //Move cursor to unit price
                txtUP.Focus();
            }
        }

        private void txtUP_TextChanged(object sender, EventArgs e)
        {
            //sales.Up = Convert.ToDouble(txtUP.Text);
        }

        private void txtDR_TextChanged(object sender, EventArgs e)
        {
            sales.Up = Convert.ToDouble(txtUP.Text);
            sales.Dr= Convert.ToDouble(txtDR.Text);

            sales.calDis();

            txtDP.Text = sales.Dp.ToString();
        }

        private void txtQS_TextChanged(object sender, EventArgs e)
        {
            sales.Q = Convert.ToInt32(txtQS.Text);
            sales.calDis();
            sales.calSA();

            txtSA.Text=sales.Sa.ToString();
        }

        private void txtUP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Read value into item name
                sales.Up = Convert.ToDouble(txtUP.Text);
                //Move cursor to unit price
                txtDR.Focus();
            }
        }

        private void txtDR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Read value into item name
                sales.Dr = Convert.ToDouble(txtDR.Text);
                //Move cursor to unit price
                txtQS.Focus();
            }
        }

        private void txtDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Read value into item name
                sales.Dp = Convert.ToDouble(txtDP.Text);
                //Move cursor to unit price
                txtQS.Focus();
            }
        }

        private void txtQS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Read value into item name
                sales.Q = Convert.ToInt32(txtQS.Text);
                //Move cursor to unit price
                txtSA.Focus();
            }
        }
    }
}
