using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper
{
    public partial class Form1 : Form
    {
        Bill bl;
        public Form1()
        {
            InitializeComponent();
            bl= new Bill();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text == "")
                {
                    return;
                }
                double c = Convert.ToDouble(txtPrice.Text);
                if (c <= 0)
                {
                    MessageBox.Show("Price can not be 0 or minus");
                    txtPrice.Clear();
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Cant enter string value");
                    txtPrice.Clear();
            }
            bl.Price=Convert.ToDouble(txtPrice.Text);
            bl.calBill();
            bl.calDis();
            bl.calF();

            txtBA.Text=bl.F.ToString();
        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQ.Text == "")
                {
                    return;
                }
                double c = Convert.ToDouble(txtQ.Text);
                if (c <= 0)
                {
                    MessageBox.Show("Price can not be 0 or minus");
                    txtQ.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant enter string value");
                    txtQ.Clear();
            }
            bl.Q=Convert.ToDouble(txtQ.Text);
            bl.calBill();
            bl.calDis();
            bl.calF();

            txtBA.Text = bl.F.ToString();
        }

        private void txtDR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDR.Text == "")
                {
                    return;
                }
                double c = Convert.ToDouble(txtDR.Text);
                if (c < 0)
                {
                    MessageBox.Show("Price can not be 0 or minus");
                    txtDR.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant enter string value");
                txtDR.Clear();

            }
            bl.DR=Convert.ToDouble(txtDR.Text);

            bl.calBill();
            bl.calDis();
            bl.calF();

            txtBA.Text = bl.F.ToString();
        }
    }
}
