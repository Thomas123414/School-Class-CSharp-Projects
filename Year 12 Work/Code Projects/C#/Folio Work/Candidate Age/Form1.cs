using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidate_Age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnvote_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;
            int Age = int.Parse(txtage.Text);
            
            if (Age >= 18)
            {
                lblresult.Text = "Hello " + Name + ", You are eligible to vote.";
                txtname.Clear();
                txtage.Clear();
            }
            else
            {
                lblresult.Text = "Hello " + Name + ", You are not eligible to vote.";
                txtname.Clear();
                txtage.Clear();
            }
        }
    }
}
