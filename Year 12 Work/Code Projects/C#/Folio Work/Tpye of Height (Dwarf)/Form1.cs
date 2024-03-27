using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpye_of_Height__Dwarf_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtname.Clear();    
            txtheight.Clear();
        }

        private void btnheight_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;
            double Height = double.Parse(txtheight.Text);

            if (Height <= 150)
            {
                lblresult.Text = "Hello " + Name + ", You're a dwarf.";
                txtname.Clear();
                txtheight.Clear();
            }
            else if(Height > 150 && Height <= 175)
            {
                lblresult.Text = "Hello " + Name + ", You're Average height.";
                txtname.Clear();
                txtheight.Clear();
            }
            else if (Height > 175)
            {
                lblresult.Text = "Hello " + Name + ", You are taller than the average person.";
                txtname.Clear();
                txtheight.Clear();
            }
        }
    }
}
