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
            List<Control> TextBoxes = GetTextBoxes(); // List of textbox controls on the form
            if (ValidateTextBoxes(TextBoxes)) // Check input of textboxes for valid values
            {
                int sum = SumEggs(TextBoxes); // Gets sum of all textboxes
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
        int SumEggs(List<Control> TextBoxes)
        {
            int sum = 0;
            foreach (TextBox t in TextBoxes)
            {
                sum += Convert.ToInt32(t.Text);
            }
            return sum;
        }

        /*
         * Loops through list of textboxes and validates their values are neither blank nor negative.
         * Returns false if any boxes have an invalid input or true otherwise.
         */
        bool ValidateTextBoxes(List<Control> TextBoxes)
        {
            foreach (TextBox t in TextBoxes)
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
        List<Control> GetTextBoxes()
        {
            List<Control> TextBoxes = new List<Control>();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBoxes.Add(c);
                }
            }
            return TextBoxes;
        }
    }
}
