using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_different_passwords
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] passwords = { "password1", "password2", "password3", "password4", "password5", "password6", "password7", "password8", "password9", "password10" };
            string input = textBox1.Text;

            bool accessGranted = false;

            foreach (string password in passwords)
            {
                if (input == password)
                {
                    accessGranted = true;
                    break;
                }
            }

            if (accessGranted)
            {
                MessageBox.Show("Access Granted!");
            }
            else
            {
                MessageBox.Show("Access Denied!");
            }
        }
    }
}
