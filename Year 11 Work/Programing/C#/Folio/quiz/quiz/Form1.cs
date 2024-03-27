using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int score;
        public string[] questions = {"What month and year was Thomas borned?", "What year did covid start?", "What object in space used to be our 9th planet?", "Is it possible we will ever reach the edge of the universe?(yes/no)", "What is the speed of light?(In Scientific Notation)"};
        public string[] answers = {"May 2006", "2019", "Pluto", "No", "3x10^8 m/s"};
        public int count;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (answers[count]==txtAnswer.Text)
            {
                MessageBox.Show("Correct!!");
                score++;
            }
            else
            {
                MessageBox.Show("Incorrect!! The Answer was " + answers[count]);
            }

            if (count < 4)
            {
                count++;

                lblquestion.Text = questions[count];
            }
            lblscore.Text = ("Score: " + score);
            txtAnswer.Clear();
        }

        private void lblquestion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblquestion.Text = questions[0];
            count = 0;
        }
    }
}
