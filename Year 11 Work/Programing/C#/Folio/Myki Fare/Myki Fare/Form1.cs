using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Myki_Fare
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

        private void btnDisplayfare_Click(object sender, EventArgs e)
        {
            int Age = int.Parse(txtAge.Text);
            String Zone = txtZone.Text;
            if (Age <= 4)
            {
                MessageBox.Show("Your Fare is $0");
            }
            else if (((Age >= 5) && (Age <= 18)) && Zone == "1+2")
            {
                MessageBox.Show("Your Fare is $4.60");
            }
            else if (((Age >= 5) && (Age <= 18)) && Zone == "2")
            {
                MessageBox.Show("Your Fare is $3.10");
            }
            else if ((Age > 18) && Zone == "1+2")
            {
                MessageBox.Show("Your Fare is $9.20");
            }
            else if ((Age > 18) && Zone == "2")
            {
                MessageBox.Show("Your Fare is $6.20");
            }
        }
    }
}
