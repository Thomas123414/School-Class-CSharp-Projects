using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    /*
     * Programmer Name: Thomas Andrews
     * Project Completion Date: 05/04/2023
     * Project Description: You type in a number in the textbox and it will say happy holidays the amount of which you choose in the textbox and then will display this in a listbox that text how many times you choose. 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            int reps = int.Parse(txtReps.Text);   // Sets the variable reps to the amount you put in the textbox(txtreps)
            
            for(int i = 1;i <= reps; i++)   // This bit of code repeats the line happy holidays! in a listbox as many times as the value of the variable reps
            {
                lstOutput.Items.Add("Happy Holidays!" + i);
            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
