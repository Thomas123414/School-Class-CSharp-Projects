using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circumference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float radius = float.Parse(txtRadius.Text);
            float angle = float.Parse(txtAngle.Text);
            float per = (2 * radius + (angle / 360) * 2 * 3.14f * radius);
            lstOutput.Items.Add("The Perimeter is: " + per);
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
