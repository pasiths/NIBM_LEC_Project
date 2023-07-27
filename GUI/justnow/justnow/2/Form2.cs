using justnow._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justnow
{
    public partial class Form2 : Form
    {
        CalSalary cs;
        public Form2()
        {
            InitializeComponent();
            cs = new CalSalary();
        }

        private void txtxBasic_Salary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Read value into item name
                cs.Bs = Convert.ToInt32(txtxBasic_Salary.Text);
                //Move cursor to unit price
                txtOT_Hours.Focus();
            }
        }

        private void txtOT_Hours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cs.Ot = Convert.ToInt32(txtOT_Hours.Text);
                txtFinal_Salary.Focus();
            }
        }

        private void txtxBasic_Salary_TextChanged(object sender, EventArgs e)
        {
            cs.Bs = Convert.ToInt32(txtxBasic_Salary.Text);
            //cs.Ot = Convert.ToInt32(txtOT_Hours.Text);

           cs.cal();

            txtFinal_Salary.Text = cs.Fs.ToString();
        }

        private void txtOT_Hours_TextChanged(object sender, EventArgs e)
        {
            //cs.Bs = Convert.ToInt32(txtxBasic_Salary.Text);
            cs.Ot = Convert.ToInt32(txtOT_Hours.Text);

            cs.cal();

            txtFinal_Salary.Text = cs.Fs.ToString();
        }
    }
}
