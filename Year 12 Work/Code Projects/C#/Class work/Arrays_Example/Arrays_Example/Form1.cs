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
using System.Xml.Linq;

namespace Arrays_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] names = { "John", "Fred", "James", "Jill" };

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            foreach (string name in names)
            {
                lstOutput.Items.Add(name);
                names.Count();
            }
           
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name_to_search = txtSearch.Text;
            bool found = false;
            foreach(string name in names)
            {
                if(name == name_to_search)
                {
                    found = true; break;
                }
            }
            if (found == true)
            {
                MessageBox.Show("Name Found!");
            }
            else
            {
                MessageBox.Show("Name not found!");
            }
        }

        private void btnDisplayNos_Click(object sender, EventArgs e)
        {
            int[] ages = { 12, 13, 14, 15, 16, 17, 18 };
            float total = 0;
            float avg = 0;

            foreach (int age in ages)
            {
                lstOutput.Items.Add(age);
                total += age;
            }
            lstOutput.Items.Add("Total: " + total);
            lstOutput.Items.Add("Average: " + total / ages.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInputToArray_Click(object sender, EventArgs e)
        {
            string name1 = txtName1.Text;
            string name2 = txtName2.Text;
            string name3 = txtName3.Text;
            string name4 = txtName4.Text;

            string[] names_input = { name1, name2, name3, name4 };

            foreach (string name in names_input)
            {
                lstOutput.Items.Add(name);
            }
            /*
             * Alt version of the foreach loop above
             * for (int i=0; i < 4; i++)
             * {
             *      lstOutput.Items.Add(names.input[i]);
             * }
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
