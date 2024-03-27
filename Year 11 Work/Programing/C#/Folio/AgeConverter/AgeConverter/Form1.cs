using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age_years = int.Parse(txtAge.Text);
            int age_minutes;
            age_minutes = age_years * 525600;
            lstOutput.Items.Add("You are " + age_minutes + " minutes old");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age_years = int.Parse(txtAge.Text);
            int age_seconds;
            age_seconds = age_years * 31536000;
            lstOutput.Items.Add("You are " + age_seconds + " seconds old");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
