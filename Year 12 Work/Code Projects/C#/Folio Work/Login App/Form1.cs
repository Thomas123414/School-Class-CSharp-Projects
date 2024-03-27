using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Boolean Usercorrect = false;
        Boolean Passcorrect = false;
        string[] User = { "David", "Emily", "Michael", "Thomas", "Jessica", "James", "Amanda" };
        string[] Pass = { "David4324", "Yes", "Michael12312", "Jessica7231874", "Jaida123414", "James903241", "Amanda9029349342" };
        int Attempts = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUser.Text;
            string Password = txtPass.Text;
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Make sure to fill in all the details");
            }
            else
            {
                foreach (string u in User)
                {
                    if (u == Username)
                    {
                        Usercorrect = true;
                    }
                }

                foreach (string p in Pass)
                {
                    if (p == Password)
                    {
                        Passcorrect = true;
                    }
                }

                if (Usercorrect == true && Passcorrect == true)
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    Usercorrect = false;
                    Passcorrect = false;
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                    Attempts += 1;
                    if (Attempts == 4)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
