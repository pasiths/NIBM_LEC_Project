using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_8_Q_32
{
    public partial class FrmEmpSal : Form
    {
        Salary sl;
        public FrmEmpSal()
        {
            InitializeComponent();
            sl = new Salary();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sl.Name = TxtName.Text;
                TxtBS.Focus();
            }
        }

        private void TxtBS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sl.Bs = Convert.ToInt32(TxtBS.Text);
                TxtOT.Focus();
            }
        }

        private void TxtBS_TextChanged(object sender, EventArgs e)
        {
            sl.Bs = Convert.ToInt32(TxtBS.Text);
            sl.calSalary();
            TxtFS.Text = sl.Fs.ToString();
        }

        private void TxtOT_TextChanged(object sender, EventArgs e)
        {
            sl.Ot = Convert.ToInt32(TxtOT.Text);
            sl.calSalary();
            TxtFS.Text = sl.Fs.ToString();
        }
    }
}
