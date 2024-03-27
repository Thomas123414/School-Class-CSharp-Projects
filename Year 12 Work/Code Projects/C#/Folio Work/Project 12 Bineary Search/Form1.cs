using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_Bineary_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValue.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
             int Search = int.Parse(txtValue.Text);
            bool found = false;
            int start = Numbers[0];
            int end = Numbers.Length;

            while (found == false)
            {
                int middle = (start + end) / 2;
                int middleValue = Numbers[middle];

                if (Search == middleValue)
                {
                    MessageBox.Show("Number founded!");
                    txtValue.Text = "";
                    break;
                }
                else
                {
                    if (Search < middleValue)
                    {
                        end = middle;
                    }
                    else
                    {
                        start = middle;
                    }

                    if (Search >= end)
                    {
                        MessageBox.Show("Date dont exist!");
                        break;
                    }
                }
                
            }

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
