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

namespace Jims_Seed_Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int selected_ID = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ID; //string ID = txtId.Text;               //Assign Input variables
            string SeedVariety = txtVariety.Text;
            string SeedLocation = txtLocation.Text;
            string NumberofSeeds = txtNumber.Text;
            string Cost = txtCost.Text;

            if (txtVariety.Text == "" || txtLocation.Text == "" || txtNumber.Text == "" || txtCost.Text == "")
            {
                MessageBox.Show("Make sure to fill in all fields to be able to save to file");
            }
            else
            {
                string path = "SeedCollection.txt";  //Stores in project folder
                if (File.Exists("SeedCollection.txt"))
                {
                    string[] lines = File.ReadAllLines("SeedCollection.txt");
                    string[] items = (lines[lines.Length - 1].Split(','));
                    int new_id = int.Parse(items[0]) + 1;
                    ID = new_id.ToString();
                }
                else
                {
                    ID = "1";
                }
                string record = ID + ',' + SeedVariety + ',' + SeedLocation + ',' + NumberofSeeds + ',' + Cost;   //Store all fields in 1 line separated by commas

                using (TextWriter tw = new StreamWriter(path, true))    //Use StreamWriter function to store/append record to file - will create file if it doesnt exist
                {
                    tw.WriteLine(record);
                    MessageBox.Show("Record successfully added!");
                    tw.Close();     //Close file
                }
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lsvOutput.Items.Clear();
            string path = "SeedCollection.txt";
            string[] lines = File.ReadAllLines(path);  //Open file and store each line of the textfile into the array lines
            float totalValue = 0f;
            string term = Search.Text.Trim().ToLower();


            foreach (string line in lines)              //Go through the file array 1 line at a time
            {

                string[] items = line.Split(',');  //Put each field in the line into an array (items) using split function 

                if (items[1].ToLower().Contains(term))
                {
                    ListViewItem listItem = new ListViewItem();   //"Row" object.

                    //For each item in the line. Display each record field in the Listview table row
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (i == 4 && float.TryParse(items[i], out float value))
                        {
                            totalValue += value;
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

                    lsvOutput.Items.Add(listItem); //Add the row object to the listview.
                    txtTotal.Text = "Total seed value: " + totalValue.ToString();
                }
            }


        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvOutput.SelectedItems.Count == 0)       //if listview row is not selected
            {
                MessageBox.Show("Please select a record to edit!");
            }
            else
            {
                selected_ID = lsvOutput.SelectedIndices[0];      //store the index of the selected listview object
                Edit f2 = new Edit();                            //Create an instance of the Edit form
                f2.ShowDialog();                                 //Open the form
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsvOutput.Items.Clear();
            string path = "SeedCollection.txt";
            string[] lines = File.ReadAllLines(path);  //Open file and store each line of the textfile into the array lines



            foreach (string line in lines)              //Go through the file array 1 line at a time
            {

                string[] items = line.Split(',');  //Put each field in the line into an array (items) using split function 
                int NumberofSeeds = int.Parse(items[3]);
                int ValueofSeeds = int.Parse(items[4]);
                if (NumberofSeeds <= 15 && ValueofSeeds <= 5)
                {
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
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            string path = "SeedCollection.txt";
            string[] lines = File.ReadAllLines(path);

            string[] SortStringArray(string[] Array)
            {
                var arrayLength = Array.Length;
                for (int i = 0; i < arrayLength - 1; i++)
                {
                    var smallestVal = i;
                    for (int j = i + 1; j < arrayLength; j++)
                    {
                        if (String.Compare(Array[j], Array[smallestVal]) < 0)
                        {
                            smallestVal = j;
                        }
                    }
                    var tempVar = Array[smallestVal];
                    Array[smallestVal] = Array[i];
                    Array[i] = tempVar;
                }
                return Array;
            }

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
            }
        }
    }
}
