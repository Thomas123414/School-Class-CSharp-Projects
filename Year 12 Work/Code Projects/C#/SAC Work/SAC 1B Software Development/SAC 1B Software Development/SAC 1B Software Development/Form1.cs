using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC_1B_Software_Development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             * DeveloperName: Thomas Andrews
             * DateOfCompletetion: 23/02/2024
             * Description: An app to login to staff and student side of a jobs list for staff to fix problems that students have had which have posted to the job view 
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); //This opens the student side of the job list (form2) so students can submit problems to the staff
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); //This opens the staff side of the job list (form3) so staff can see all the students problems that need to be fixed 
            f3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //This exits the app so that people who want to quit the app can do so 
        }
    }
}   
