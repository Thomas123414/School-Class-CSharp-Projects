using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting_and_Total
{
    /*
     * Programmer Name: Thomas Andrews
     * Completed Project Date: 05/04/2023
     * Project Description: When you click the button it counts 2 into the listbox and when repeated it adds to 2 to the total in the listbox as many times as you click it.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //This bit of code adds 2 to the total
            int total=0;
            for (int i = 2; i <= 100; i += 2)
            {
                lstOutput.Items.Add(i);
                total += i;
            }
            //This displays the message (The Total is: and what ever the value of the variable total is)  
            lstOutput.Items.Add("The Total is: " + total);
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
