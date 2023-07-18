using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_7_Q_28
{
    public partial class frmBill : Form
    {
        BillCal bc;
        public frmBill()
        {
            InitializeComponent();
            bc= new BillCal();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            bc.PTT = Convert.ToInt32(txtPTT.Text);
            bc.STT = Convert.ToInt32(txtSTT.Text);

            bc.cal();

            txtFBA.Text = bc.BA.ToString();
        }
    }
}
