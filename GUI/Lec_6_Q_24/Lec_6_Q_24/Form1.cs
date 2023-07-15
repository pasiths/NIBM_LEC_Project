using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_6_Q_24
{
    public partial class frmAddition : Form
    {
        public frmAddition()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);

            int add=num1 + num2;
            MessageBox.Show("Addition: " + add);
        }
    }
}
