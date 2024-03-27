using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_you_feeling
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

        private void btnResponded_Click(object sender, EventArgs e)
        {
            string mood = txtFeelings.Text.ToLower();
            int age = int.Parse(txtAge.Text);

            if (mood == "good" && (age >= 18))
            {
                MessageBox.Show("You can drive a car!");
            }
            else if (mood == "good" && (age< 18))
            {
                MessageBox.Show("AWW YOUR A LITTLE KID!");
            }
            else if (mood == "OK")
            {
                MessageBox.Show("I hope you have a good day");
            }
            else if (mood == "bad")
            {
                MessageBox.Show("I hope your day gets better!");
            }
            else
            {
                MessageBox.Show("Im sorry I don't know how to responed to that");
            }
        }

        private void txtFeelings_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
