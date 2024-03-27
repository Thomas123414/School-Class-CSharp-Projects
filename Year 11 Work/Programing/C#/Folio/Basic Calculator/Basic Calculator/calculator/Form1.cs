using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int num1;
        public int num2;
        private void asignvars() 
        {
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
           
        }
        private int Add(int num1, int num2) 
        {
            return num1 + num2;
        }
        private int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        private int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        private int Times(int num1, int num2)
        {
            return num1 * num2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            asignvars();
            MessageBox.Show(Convert.ToString(Add(num1,num2)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asignvars();
            MessageBox.Show(Convert.ToString(Subtract(num1, num2)));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            asignvars();
            MessageBox.Show(Convert.ToString(Divide(num1, num2)));
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            asignvars();
            MessageBox.Show(Convert.ToString(Times(num1, num2)));
        }
    }
}
