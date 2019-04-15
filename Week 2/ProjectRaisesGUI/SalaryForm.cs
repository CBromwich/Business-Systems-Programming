
/*
 * Form1.cs
 * @Author: Cody Bromwich
 * @Date: 4/15/2019
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRaisesGUI
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_calculate_Click(object sender, EventArgs e)
        {
            // Set the text of the modifiedSalary label to the value of the text box * 1.04 (4%)
            label_modifiedSalary.Text = Convert.ToString(Convert.ToDouble(textbox_currentSalary.Text) * 1.04);
        }
    }
}
