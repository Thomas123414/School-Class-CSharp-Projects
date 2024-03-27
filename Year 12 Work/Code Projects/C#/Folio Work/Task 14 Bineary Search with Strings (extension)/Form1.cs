using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_14_Bineary_Search_with_Strings__extension_
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] StringArray = { "Alessica", "Ben", "Haydn", "Luke", "Mat", "Nick", "Oliver", "Penny", "Thomas", "William" };

            string Search = txtSearch.Text;
            bool found = false;
            string start = StringArray[0];
            int end = StringArray.Length;

            while (found == false)
            {
                int middle = (0 + end) / 2;
                int middleValue = StringArray[middle];

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
    }
}
