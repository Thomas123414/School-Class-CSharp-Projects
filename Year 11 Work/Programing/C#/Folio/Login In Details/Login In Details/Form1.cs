using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_In_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (Username == "Thomas123414" && Password == "Father1245")
            {
                MessageBox.Show("You have hacked into the mainframe!");
            }
            else
            {
                MessageBox.Show("Access Denied!");
            }
        }
    }
}
