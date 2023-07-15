using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_6_Q_25
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        private double num1;
        private double num2;
        private double ans = 0;
        private void cal(string opcode)
        {
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            if (opcode == "+")
            {
                ans=num1+num2;
            }
            else if (opcode == "-")
            {
                ans=num1-num2;
            }
            else if (opcode == "*")
            {
                ans=num1*num2;
            }
            else if(opcode == "/")
            {
                ans = num1 / num2;
            }
            else if (opcode == "%")
            {
                ans = num1 % num2;
            }

            MessageBox.Show("Answer: " + ans);
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cal("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            cal("-");
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            cal("%");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cal("/");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            cal("*");
        }
    }
}
