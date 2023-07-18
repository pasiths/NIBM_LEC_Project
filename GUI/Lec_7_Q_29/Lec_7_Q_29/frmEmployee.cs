using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_7_Q_29
{
    public partial class frmEmployee : Form
    {
        CalSalary cs;
        frmDisplay dis;

        public frmEmployee()
        {
            InitializeComponent();

            cs = new CalSalary();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            cs.BS=Convert.ToInt32(txtBS.Text);
            cs.OT=Convert.ToInt32(txtOT.Text);

            cs.cal();

            int fs=cs.FS;

            dis = new frmDisplay(name,fs);
            dis.Show();

        }
    }
}
