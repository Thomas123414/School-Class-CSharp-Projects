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

namespace Tax_and_Net_Income_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            float income = float.Parse(txtgyi.Text);
            float Tax = 0;
            if (income <= 18200)
                {
                    Tax = 0;
                }
            else if (income >= 18201 == income <= 45000) 
                {
                    Tax = 0.19f * (income - 18200);
                }
            else if (income >= 45001 == income <= 120000)
                {
                    Tax = 5092f + 0.325f * (income - 45000);
                }
            lstOutput.Items.Add("You will pay $" + Tax + " in tax this year");
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtgyi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
