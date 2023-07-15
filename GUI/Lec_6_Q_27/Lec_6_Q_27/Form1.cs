using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_6_Q_27
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int uc = Convert.ToInt32(txtUC.Text);
            int q = Convert.ToInt32(txtQ.Text);

            int amount = uc * q;

            txtAmount.Text= amount.ToString();
        }
    }
}
