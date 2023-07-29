using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP212_Q_1
{
    public partial class FrmBillSystem : Form
    {
        calBill cb;
        public FrmBillSystem()
        {
            InitializeComponent();
            cb = new calBill();
            cmbType();
        }

        public void cmbType()
        {
            string[] type = { "Double Blast", "Triple Blast" };
            for (int i = 0; i < type.Length; i++)
            {
                cmbDataType.Items.Add(type[i]);
            }
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            cb.DataType=cmbDataType.SelectedItem.ToString();
            cb.Day=Convert.ToInt32(TxtDay.Text);
            cb.Night=Convert.ToInt32(TxtNight.Text);

            cb.cal();

            TxtBA.Text=cb.Ba.ToString();
        }
    }
}
