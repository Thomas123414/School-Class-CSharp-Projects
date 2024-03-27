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
using System.Xml.Schema;

namespace Year_12_Mentor_Swap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtYear7.Clear();
            txtYear12.Clear();
            txtAlt.Clear();
            txtSession.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //total time for all sessions button 
            if (txtSession.Text == "")
            {
                MessageBox.Show("Make sure to fill in all fields");
            }
            else
            {
                int Totaltime = Int32.Parse(txtSession.Text) * 20;
                lstMentor.Items.Add("Total Mins: " + Totaltime);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //display new mentor button
            lstMentor.Items.Clear();
            string Year7Name = txtYear7.Text;
            string MentorAlt = txtAlt.Text;
            if (Year7Name == "" || MentorAlt == "")
            {
                MessageBox.Show("Make sure to fill in all fields ");
            }
            else
            {
                lstMentor.Items.Add("Year 7 Student" + "\t\t" + "Mentor");
                lstMentor.Items.Add(Year7Name + "\t\t\t" + MentorAlt);
            }

        }

        private void btnYear7_Click(object sender, EventArgs e)
        {
            lstMentor.Items.Clear();
            string Year7Name = txtYear7.Text;
            string Mentor = txtYear12.Text;
            if (Year7Name == "" || Mentor == "")
            {
                MessageBox.Show("Make sure to fill in all fields ");
            }
            else
            {
                lstMentor.Items.Add("Year 7 Student" + "\t\t" + "Mentor");
                lstMentor.Items.Add(Year7Name + "\t\t\t" + Mentor);
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (txtAlt.Text == "" || txtYear12.Text == "")
            {
                MessageBox.Show("Make sure to fill in all fields ");
            }
            else
            {
                lstMentor.Items.Clear();
                string New_mentor = txtAlt.Text;
                string mentor = txtYear12.Text;
                string temp;

                temp = mentor;
                mentor = New_mentor;
                New_mentor = temp;

                txtYear12.Text = mentor;
                txtAlt.Text = New_mentor;
            }
        }
    }
}
