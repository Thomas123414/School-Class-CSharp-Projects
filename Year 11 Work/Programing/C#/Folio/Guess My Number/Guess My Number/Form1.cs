using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Guess_My_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Count = 0;
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(txtNum.Text);
            Count++;
            if(Count > 5)
            {
                lstRight.Items.Add("Too Many Guesses");
                this.Close();
            }
            if (Num == number)
            {
                lstRight.Items.Add("You Won You Got The Right Number!");
            }
            else if (Num > number)
            {
                lstRight.Items.Add("The Number Is lower");
            }
            else if (Num < number)
            {
                lstRight.Items.Add("The Number Is Higher");
            }
            txtNum.Clear();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }
        int number;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            number = rand.Next(0, 100);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            number = rand.Next(0, 100);
        }
    }
}
