using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SAC_1C_Software_Development
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        /*
         * DeveloperName: Thomas Andrews
         * DateOfCompletetion: 08/03/2024
         * Description: An app for students to log their info such as their house, age, fullname, event and year level for swimming. They can also edit their info that they sumbited before to chnages things up while teachers can view all the students info and events in a listview box. 
         */

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex objAlphaPattern = new Regex("[a-zA-Z][a-zA-Z]");  //to alllow for type check so i can check they match letters or numbers
            Regex objNumberPattern = new Regex("[0-9.-]$");

            string Event = cbEvent.Text;
            string GivenName = txtGivenName.Text;
            string Surname = txtSurname.Text;
            string Age = cbAge.Text;                    //setting values to variables so i can access the data from the form
            string House = cbHouse.Text;
            string YearLevel = cbYear.Text;
            string Gender = "";
            string path = "swim.txt";

            if (CBMale.Checked == true)
            {
                Gender = "Male";                    //Existence Check
            }
            else if (CBFemale.Checked == true)
            {
                Gender = "Female";                  //Existence Check
            }
            else
            {
                MessageBox.Show("Make sure to check Male or Female");                   //Existence Check
                Gender = "";
            }

            if (cbEvent.Text == "" || txtGivenName.Text == "" || txtSurname.Text == "" || cbAge.Text == "" || cbHouse.Text == "" || cbYear.Text == "")    //Existence Check
            {
                MessageBox.Show("Make sure to fill in all fields to be able to save to file!");
            }
            else if (!objAlphaPattern.IsMatch(cbEvent.Text) || !objAlphaPattern.IsMatch(txtGivenName.Text) || !objAlphaPattern.IsMatch(txtSurname.Text) || !objAlphaPattern.IsMatch(cbHouse.Text))  //Type Check
            {
                MessageBox.Show("Make sure to put the right type of values in the fields!");
            }
            else if (!objNumberPattern.IsMatch(cbAge.Text) || !objNumberPattern.IsMatch(cbYear.Text))           //Type Check
            {
                MessageBox.Show("Make sure to put the right type of values in the fields!");
            }
            else
            {
                string record = Event + ',' + GivenName + ',' + Surname + ',' + Gender + ',' + House + ',' + Age + ',' + YearLevel;   //Store all fields in 1 line separated by commas

                using (TextWriter tw = new StreamWriter(path, true))    //Use StreamWriter function to store/append record to file - will create file if it doesnt exist
                {
                    tw.WriteLine(record);
                    MessageBox.Show("Record successfully added!");
                    tw.Close();     //Close file
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGivenName.Clear();
            txtSurname.Clear();
            CBFemale.Checked = false;
            CBMale.Checked = false;                 //clears all the values in the textboxs and combo boxs and check boxs
            cbAge.Text = "";
            cbEvent.Text = "";
            cbHouse.Text = "";
            cbYear.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); //closes nthe form so i can quit 
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }
    }
}
