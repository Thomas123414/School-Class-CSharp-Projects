using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_own_garage_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncars_Click(object sender, EventArgs e)
        {
            string[] cars = new string[6];
            cars[0] = textBox1.Text;

            cars[1] = textBox2.Text;

            cars[2] = textBox3.Text;

            cars[3] = textBox4.Text;

            cars[4] = textBox5.Text;

            cars[5] = textBox6.Text;

            foreach (string car in cars)
            {
                lstcars.Items.Add(car);
            }
        }
    }
}
