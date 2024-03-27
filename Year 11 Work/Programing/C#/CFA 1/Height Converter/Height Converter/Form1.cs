using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Height_Converter
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

        private void btnfeet_Click(object sender, EventArgs e)
        {
            float Height = float.Parse(txtcm.Text);
            float Feet = Height / 30.48f;
            MessageBox.Show("You Height In Feet Is " + Feet);
        }

        private void txtcm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
