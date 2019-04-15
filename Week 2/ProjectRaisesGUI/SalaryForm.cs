
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

        private void Button_calculate_Click(object sender, EventArgs e)
        {
            // Check for empty values or negative values
            if (textbox_currentSalary.Text == string.Empty || Convert.ToInt32(textbox_currentSalary.Text) < 0)
            {
                MessageBox.Show("Please enter a valid value");
            }
            else
            {
                // Set the text of the modifiedSalary label to the value of the text box * 1.04 (4%)
                label_modifiedSalary.Text = Convert.ToString(Convert.ToDouble(textbox_currentSalary.Text) * 1.04);
            }
            
        }
    }
}
