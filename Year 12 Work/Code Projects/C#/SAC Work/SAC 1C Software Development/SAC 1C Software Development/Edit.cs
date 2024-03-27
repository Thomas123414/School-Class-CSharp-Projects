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
using System.Text.RegularExpressions;

namespace SAC_1C_Software_Development
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        /*
         * DeveloperName: Thomas Andrews
         * DateOfCompletetion: 08/03/2024
         * Description: An app for students to log their info such as their house, age, fullname, event and year level for swimming. They can also edit their info that they sumbited before to chnages things up while teachers can view all the students info and events in a listview box. 
         */

        public string path = "swim.txt";
        public string[] lines = File.ReadAllLines("swim.txt");
        public int selected_index = Form1.selected_Event;                 //Get the selected index of the listview object from the previous form
        public string Event;

        private void Edit_Load(object sender, EventArgs e)
        {
            string[] items = lines[selected_index].Split(',');
            cbEvent.Text = items[0];
            txtGivenName.Text = items[1];
            txtSurname.Text = items[2];               //setting values to variables so i can access the data from the form
            txtGender.Text = items[3];
            cbHouse.Text = items[4];
            cbAge.Text = items[5];
            cbYear.Text = items[6]; 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex objAlphaPattern = new Regex("[a-zA-Z][a-zA-Z]");  //to alllow for type check so i can check they match letters or numbers
            Regex objNumberPattern = new Regex("[0-9.-]$");

            if (cbEvent.Text == "" || txtGivenName.Text == "" || txtSurname.Text == "" || cbAge.Text == "" || cbHouse.Text == "" || cbYear.Text == "")      //Existence check
            {
                MessageBox.Show("Make sure to fill in all fields to be able to save to file!");
            }
            else if (!objAlphaPattern.IsMatch(txtGivenName.Text) || !objAlphaPattern.IsMatch(txtSurname.Text) || !objAlphaPattern.IsMatch(cbHouse.Text))     //Type Check
            {
                MessageBox.Show("Make sure to put the right type of values in the fields!");
            }
            else if (!objNumberPattern.IsMatch(cbAge.Text) || !objNumberPattern.IsMatch(cbYear.Text))       //Type Check
            {
                MessageBox.Show("Make sure to put the right type of values in the fields!");
            }
            else
            {
                string record = cbEvent.Text + "," + txtGivenName.Text + "," + txtSurname.Text + "," + txtGender.Text + "," + cbHouse.Text + "," + cbAge.Text + "," + cbYear.Text;  //ID will be the same as before. The other fields can be changed
                lines[selected_index] = record;                                                        //Overwrite the record to be edited with new values
                File.WriteAllLines(path, lines);                                                      //Update the text file with new edited array (lines)
                MessageBox.Show("Saved!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();  // close the form so i can quit it
        }
    }
}
