using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Height_Calualator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstdetails.Items.Clear();
            txtheight1.Clear();
            txtheight2.Clear();
            txtheight3.Clear();
            txtheight4.Clear();
            txtheight5.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double Height1 = double.Parse(txtheight1.Text);
            double Height2 = double.Parse(txtheight2.Text);
            double Height3 = double.Parse(txtheight3.Text);
            double Height4 = double.Parse(txtheight4.Text);
            double Height5 = double.Parse(txtheight5.Text);
            
            double Total = Height1 + Height2 + Height3 + Height4 + Height5;
            double AverageCm = Total / 5;
            double AverageM = AverageCm / 100;

            lstdetails.Items.Add("The Total Height is " + Total);
            lstdetails.Items.Add("Which the Average Height in Cm's is " + AverageCm);
            lstdetails.Items.Add("And the Average Height in M's is " + AverageM);
        }

        private void lstdetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
