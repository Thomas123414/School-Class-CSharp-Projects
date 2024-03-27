using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linear_name_search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] names = { "Noah", "Olivia", "Liam", "Emma", "Amelia", "Oliver", "Elijah", "Sophia", "Charlotte", "Mateo", "Lucas", "Ava", "Lucas", "Levi", "Thomas" };
            string search = txtName.Text;
            bool found = false;

             foreach (string name in names)
            {
                if (name == search)
                {
                    found = true;
                }
                else
                {
                    found = false;
                }

                if (found == true)
                {
                    MessageBox.Show("Name founded: " + name);
                    break;
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
