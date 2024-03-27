using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAC_1C_Software_Development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * DeveloperName: Thomas Andrews
         * DateOfCompletetion: 08/03/2024
         * Description: An app for students to log their info such as their house, age, fullname, event and year level for swimming. They can also edit their info that they sumbited before to chnages things up while teachers can view all the students info and events in a listview box. 
         */

        public static int selected_Event = 0;   //variable value setted

        private void button2_Click(object sender, EventArgs e)
        {
            //view by search event button
            LsvOutput.Items.Clear();            //these four lines of code clears the listview box and sets values to variables so i can acesss values from the form in the textboxs and comboboxs 
            string path = "swim.txt";
            string[] lines = File.ReadAllLines(path);
            string term = txtSearch.Text.Trim().ToLower();

            foreach (string line in lines)              
            {

                string[] items = line.Split(',');  //Put each field in the line into an array (items) using split function so i can access indiviual data from the line of data by sorting it in a array

                if (items[0].ToLower().Contains(term))
                {
                    ListViewItem listItem = new ListViewItem();   //"Row" object. this creates the listview as a object to put data in it so i can use it in the listview box 

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

                    LsvOutput.Items.Add(listItem); //Add the row object to the listview.
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInputDetails_Click(object sender, EventArgs e)
        {
            Input f2 = new Input();                            //Create an instance of the Edit form so i can open the the input form when i click input competitar details so i can saved data to the file
            f2.ShowDialog();
        }

        private void btnViewFile_Click(object sender, EventArgs e)
        {
            LsvOutput.Items.Clear();
            txtSearch.Clear();              //these five lines of code clears the listview box and the search textbox and sets values to variables so i can acesss values from the form in the textboxs and comboboxs or files
            string path = "swim.txt";
            string[] lines = File.ReadAllLines(path);  //Open file and store each line of the textfile into the array lines
            float totalValue = 0f;
            string term = txtSearch.Text.Trim().ToLower();


            foreach (string line in lines)              //Go through the file array 1 line at a time so i can access all the data within each line for the entire file
            {

                string[] items = line.Split(',');  //Put each field in the line into an array (items) using split function so i can access indiviual data from the line of data by sorting it in a array

                if (items[1].ToLower().Contains(term))
                {
                    ListViewItem listItem = new ListViewItem();   //"Row" object.

                    //For each item in the line. Display each record field in the Listview table row
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (i == 5 && float.TryParse(items[i], out float value))
                        {
                            totalValue += value;       //alsigns the variable value to age in the array and adds all the ages together which i need to figure out the average age of everyone
                        }
                        if (i == 0)
                        {
                            listItem.Text = items[i]; //First item is not a "subitem".
                        }
                        else
                        {
                            listItem.SubItems.Add(items[i]); //Add it to the "Row" object.
                        }
                    }

                    LsvOutput.Items.Add(listItem); //Add the row object to the listview.
                    lblAverageAge.Text = "Average age of swimmers: " + (totalValue / lines.Length);    //edits a label to display the average age of all the swimmers so i can complete the task
                }
            }
        }

        private void btnEditCompetitor_Click(object sender, EventArgs e)
        {
            if (LsvOutput.SelectedItems.Count == 0)       //if listview row is not selected
            {
                MessageBox.Show("Please select a record to edit!");
            }
            else
            {
                selected_Event = LsvOutput.SelectedIndices[0];      //store the index of the selected listview object
                Edit f2 = new Edit();                            //Create an instance of the Edit form
                f2.ShowDialog();                                 //Open the form
            }
        }
    }
}
