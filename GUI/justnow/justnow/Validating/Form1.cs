using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justnow.Validating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //2.23;- TIME
        private void button1_Click(object sender, EventArgs e)
        {
            //test 2 whether the textbox contain number of characters
            

            if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Item Name Should be at least 5 characters");
                return;
            }
            //test whether the textbox contain a numerical value 
            //ex: unit price should be numeric
            Double price;
            if(Double.TryParse(textBox1.Text, out price)==false)
            {
                MessageBox.Show("Unit Price should be numerical");
                return;
            }
            //test whether the value of the textbox is within a range 
            // ex: unit price should be greater than 0
            double text=Convert.ToDouble(textBox2.Text);
            if (text <= 0)
            {
                MessageBox.Show("Unit price should be greater than 0");
                return;
            }
            //Validating Radio Buttons 
            //ex: Sales Type Should be selected
            if(radioButton1.Checked==false && radioButton2.Checked == false)
            {
                MessageBox.Show("Sales Type should be selected..");
                return;
            }
            //Validating ComboBox
            //ex: category should be selected
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Category should be selected");
                return;
            }
            MessageBox.Show("Successful");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Move cursor to unit price
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Move cursor to unit price
                button1.Focus();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Move cursor to unit price
                textBox1.Focus();
            }
        }
    }
}
