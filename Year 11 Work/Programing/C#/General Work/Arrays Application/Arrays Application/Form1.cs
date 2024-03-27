using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            int[] Num = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 1 };
            int total = 0;



            for (int i = 5; i < 10; i++)
            {
                total = total + Num[i];
                lstoutput.Items.Add(Num[i]);



            }
            lstoutput.Items.Add("Total " + total);
        }

        private void lstoutput_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnNumbers3_Click(object sender, EventArgs e)
        {
            string[] names = { "Fred", "John", "Sally", "Bill" };
            foreach (string name in names)
            {
                lstoutput.Items.Add(name);
            }
        }

        private void btnNumbers2_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 10 };



            foreach (int num in nums)
            {
                lstoutput.Items.Add(num);
            }
        }
    }
}
