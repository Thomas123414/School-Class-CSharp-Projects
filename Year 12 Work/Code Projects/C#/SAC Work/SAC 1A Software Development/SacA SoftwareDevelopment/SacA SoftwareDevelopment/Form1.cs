using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SacA_SoftwareDevelopment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
             * DeveloperName: Thomas Andrews
             * Description: Made App to swap Days and Dutys for teachers with textboxs and buttons.
             * DateOfCompletion: 09/02/2024 
             */
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Regex objAlphaPattern = new Regex("[a-zA-Z][a-zA-Z]"); // for checking textboxs have letters in them
            Regex objNumberPattern = new Regex("[0-9.-]$"); //for checking textboxs have numbers in them

            string Teacher1 = txtT1.Text;       //All the Vars
            string Teacher2 = txtT2.Text;
            string DayT1 = txtDayT1.Text;
            string DayT2 = txtDayT2.Text;
            string DutyT1 = txtDutyT1.Text;
            string DutyT2 = txtDutyT2.Text;
            string temp;

            if (Teacher1 == "" || Teacher2 == "" || DayT1 == "" || DayT2 == "" || DutyT1 == "" || DutyT2 == "")
            {
                MessageBox.Show("Make sure to fill in all Textbox's!"); //Existence Check
            }
            else if (CbtnSwapDay.Checked == false && CbtnSwapDuty.Checked == false)
            {
                MessageBox.Show("Make sure to check aleast one checkbox!"); //Existence Check
            }
            else if (!objAlphaPattern.IsMatch(txtT1.Text) || !objAlphaPattern.IsMatch(txtT2.Text) || !objAlphaPattern.IsMatch(txtDutyT1.Text) || !objAlphaPattern.IsMatch(txtDutyT1.Text))
            {
                MessageBox.Show("Make sure to fill textbox's with the right type of data!"); //Type Check
            }
            else
            {
                if (CbtnSwapDay.Checked == true) //This is to swap the days when the swapdays checkbox is ticked
                {
                    temp = DayT1;
                    DayT1 = DayT2;
                    DayT2 = temp;
                    txtDayT1.Text = DayT1;
                    txtDayT2.Text = DayT2;
                }

                if (CbtnSwapDuty.Checked == true) //This is to swap the dutys when the swapdutys checkbox is ticked
                {
                    temp = DutyT1;
                    DutyT1 = DutyT2;
                    DutyT2 = temp;
                    txtDutyT1.Text = DutyT1;
                    txtDutyT2.Text = DutyT2;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //This clears all the textboxs and checkboxs when you click the clear button
            txtT1.Clear();
            txtT2.Clear();
            txtDayT1.Clear();
            txtDayT2.Clear();
            txtDutyT1.Clear();
            txtDutyT2.Clear();
            CbtnSwapDay.Checked = false;
            CbtnSwapDuty.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This will close the window form when you click the exit button
            System.Windows.Forms.Application.Exit();
        }
    }
}
