using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class EggsCalculator : Form
    {
        public EggsCalculator()
        {
            InitializeComponent();
        }

        private void Button_calculateEggs_Click(object sender, EventArgs e)
        {
            List<Control> textBoxes = getTextBoxes(); // List of textbox controls on the form
            if (validateTextBoxes(textBoxes)) // Check input of textboxes for valid values
            {
                int sum = sumEggs(textBoxes); // Gets sum of all textboxes
                // Calculates how many dozens then how many remaining eggs and sets the text of label_eggsTotalDisplay to a
                // string displaying these values.
                label_eggsTotalDisplay.Text = Convert.ToString((sum / 12) + " dozen and " + (sum % 12) + " eggs");
            }
            else
            {
                MessageBox.Show("Please enter a valid value for all fields");
            }
        }

        /*
         * Loops through list of textboxes on the form and adds the values in them after converting them to ints.
         * Returns an int equal to the value of the sum of all textboxes on the form.
         */
        int sumEggs(List<Control> textBoxes)
        {
            int sum = 0;
            foreach (TextBox t in textBoxes)
            {
                sum += Convert.ToInt32(t.Text);
            }
            return sum;
        }

        /*
         * Loops through list of textboxes and validates their values are neither blank nor negative.
         * Returns false if any boxes have an invalid input or true otherwise.
         */
        bool validateTextBoxes(List<Control> textBoxes)
        {
            foreach (TextBox t in textBoxes)
            {
                if (t.Text == string.Empty || Convert.ToInt32(t.Text) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        /*
         * Loops through all controls and builds a list of textboxes on the form. 
         * Returns a list of Controls that are all textboxes.
         */
        List<Control> getTextBoxes()
        {
            List<Control> textBoxes = new List<Control>();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add(c);
                }
            }
            return textBoxes;
        }
    }
}
