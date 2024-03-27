using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC_1B_Software_Development
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            /*
             * DeveloperName: Thomas Andrews
             * DateOfCompletetion: 23/02/2024
             * Description: An app to login to staff and student side of a jobs list for staff to fix problems that students have had which have posted to the job view 
             */
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string path = "service_request.txt";
            string[] lines = File.ReadAllLines(path);  //Open file and store each line of the textfile into the array lines

            foreach (string line in lines)              //Go through the file array 1 line at a time
            {

                string[] items = line.Split(',');  //Put each field in the line into an array (items) using split function

                ListViewItem listItem = new ListViewItem();   //"Row" object.

                //For each item in the line. Display each record field in the Listview table row
                for (int i = 0; i < items.Length; i++)
                {
                    if (i == 0)
                    {
                        listItem.Text = items[i]; //First item is not a "subitem".
                    }
                    else
                    {
                        listItem.SubItems.Add(items[i]); //Add it to the "Row" object.
                    }
                }

                lsvOutput.Items.Add(listItem); //Add the row object to the listview.

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
