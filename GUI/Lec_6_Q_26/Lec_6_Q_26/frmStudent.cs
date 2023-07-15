using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_6_Q_26
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int exam=int.Parse(txtExam.Text);
            int assigment=Convert.ToInt32(txtAssigment.Text);
            string result;

            double avg = (exam + assigment) / 2;

            if (avg > 65)
            {
                result = "Distination";
            }else if (avg > 35)
            {
                result = "General Pass";
            }
            else
            {
                result = "Fail";
            }

            txtResult.Text = result;
        }
    }
}
