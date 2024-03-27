using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_i_can_copy_for_Sac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();    // go to project then add new form then put this code into the codebase and wheen pressing a button it should send you there
            f2.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int[] SortIntArray(int[] Array) //Selection Sort Algorithms for ints
            {
                var arrayLength = Array.Length;
                for (int i = 0; i < arrayLength - 1; i++)
                {
                    var smallestVal = i;
                    for (int j = i + 1; j < arrayLength; j++)
                    {
                        if (Array[j] < Array[smallestVal])
                        {
                            smallestVal = j;
                        }
                    }
                    var tempVar = Array[smallestVal];
                    Array[smallestVal] = Array[i];
                    Array[i] = tempVar;
                }
                return Array;
            }


            string[] SortStringArray(string[] Array) //Selection Sort Algorithms for strings
            {
                var arrayLength = Array.Length;
                for (int i = 0; i < arrayLength - 1; i++)
                {
                    var smallestVal = i;
                    for (int j = i + 1; j < arrayLength; j++)
                    {
                        if (String.Compare(Array[j], Array[smallestVal]) < 0)
                        {
                            smallestVal = j;
                        }
                    }
                    var tempVar = Array[smallestVal];
                    Array[smallestVal] = Array[i];
                    Array[i] = tempVar;
                }
                return Array;
            }
        }




        public string getdata;

        private void button1_Click(object sender, EventArgs e)
        {
            //form2 frm = new form2();
            //this.hide();
            //form2.show();

            //form1 frm = new form1();        // this code should be in the form that has the data sending it over  
            //form1.getdata = "some string to be sent to form1";
        }
    }
    
    
    
}
