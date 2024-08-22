using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNRunCode_Click(object sender, EventArgs e)
        {
            // Clear the ListBox for output 
            ListBoxOutput.Items.Clear();
            // Declare several variables
             int num1 = 0;
             int num2 = 0; 
             int sum = 0; 
             int product = 0;
            // Test if both TextBoxes have integer values
            if (!((int.TryParse(TextBoxNumber1.Text, out num1)) 
                && (int.TryParse(TextBoxNumber2.Text, out num2)))) 
            { // Report error message
              MessageBox.Show("That is not an integer"); 
            }
            else
            {
                if(num1>num2)
                {
                    ListBoxOutput.Items.Add("Number 1 is greater");
                }
                else
                {
                    ListBoxOutput.Items.Add("Number 2 is greater");
                }
                sum = num1 + num2; 
                product = num1 * num2; 
                ListBoxOutput.Items.Add("The sum is " + sum); 
                ListBoxOutput.Items.Add("The product is " + product);
            }
            TextBoxNumber1.Clear(); 
            TextBoxNumber2.Clear();
        }
    }
}
