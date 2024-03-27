using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC_1B_Software_Development
{
    public partial class Form2 : Form
    {
        public Form2()
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
            Regex objAlphaPattern = new Regex("[a-zA-Z][a-zA-Z]"); // for checking textboxs have letters in them
            Regex objNumberPattern = new Regex("[0-9.-]$"); //for checking textboxs have numbers in them

            string ID;
            string Username = txtUser.Text;
            string Category = cbCategory.Text;
            string ComputerNum = txtComputerNo.Text;
            string RoomNumber = txtRoom.Text;           //Variables so to i can get all the values from the textboxs
            string Date = DTP.Value.ToShortDateString();
            string PriorityLevel = cbPriority.Text;
            string Comment = txtComment.Text;
            
            string path = "service_request.txt";
            if (Username == "" || Category == "" || ComputerNum == "" || RoomNumber == "" || Date == "" || PriorityLevel == "" || Comment == "" )
            {
                MessageBox.Show("Make sure to fill in all fields!"); //Existence check to check that all the data has been filled in so that when you saved, it doesn't error because there isnt any data which it will tell you in the form of a messagebox 
                return;
            }
            else if (!objAlphaPattern.IsMatch(txtUser.Text) || !objNumberPattern.IsMatch(txtComputerNo.Text) || !objNumberPattern.IsMatch(txtRoom.Text) || !objNumberPattern.IsMatch(cbPriority.Text))
            {
                MessageBox.Show("Make sure to fill in the data with the right type of data!"); //Type Check to make sure that the right data has been filled in so that it doesn't error with wrong data, it will tell you this in a message box
            }
            else
            {
                if (File.Exists("service_request.txt")) //checks if file exist so it can excute this code
                {
                    string[] lines = File.ReadAllLines("service_request.txt");
                    string[] items = (lines[lines.Length - 1].Split(','));  // checks the id of the last set of data so if there is previose data then it will add 1 to the id for the new set of data so that can all be sperated by id
                    int new_id = int.Parse(items[0]) + 1;
                    ID = new_id.ToString();
                }
                else
                {
                    ID = "1"; // if no set of data exists yet then first data saved will have id of 1 
                }
                string record = ID + ',' + Username + ',' + Category + ',' + ComputerNum + ',' + RoomNumber + ',' + Date + ',' + PriorityLevel + ',' + Comment;
                // sets al the data to the variable record and sperates the by , between each value
                using (TextWriter tw = new StreamWriter(path, true))  
                {
                    tw.WriteLine(record); //writes alll the data in the variable record to the file service_request.txt and saves it there and will tell you that it is saved in a message box
                    tw.Close();
                    MessageBox.Show("Saved!");                
                }
            }
        }
    }
}
