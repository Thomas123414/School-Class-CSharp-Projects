using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_In_Years
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Year = DateTime.Now.Year - dtp1.Value.Year;

            lbl1.Text = ("Your " + Year.ToString() + " Years old");

            if (Year <= 0)
            {
                lbl1.Text = null;
                MessageBox.Show("You wouldn't have been born yet, Stop lying");

            }
        }
    }
}
