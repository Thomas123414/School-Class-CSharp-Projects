using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_17_Sort_Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] NumArray = { 1, 58, 5, 100, 10, 12, 13, 17, 7, 8, 20, 14, 15, 25, 4, 9, 37, 48, 99, 69 };

            int[] SortIntArray(int[] Array)
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

            SortIntArray(NumArray);
            lblSorted.Text = NumArray[0].ToString() + ", " + NumArray[1].ToString() + ", " + NumArray[2].ToString() + ", " + NumArray[3].ToString() + ", " + NumArray[4].ToString() + ", " + NumArray[5].ToString() + ", " + NumArray[6].ToString() + ", " + NumArray[7].ToString() + ", " + NumArray[8].ToString() + ", " + NumArray[9].ToString() + ", " + NumArray[10].ToString() + ", " + NumArray[11].ToString() + ", " + NumArray[12].ToString() + ", " + NumArray[13].ToString() + ", " + NumArray[14].ToString() + ", " + NumArray[15].ToString() + ", " + NumArray[16].ToString() + ", " + NumArray[17].ToString() + ", " + NumArray[18].ToString() + ", " + NumArray[19].ToString();   
        }

        private void btnSortString_Click(object sender, EventArgs e)
        {
            string[] StringArray = { "Thomas", "Mat", "Haydn", "Luke", "Alessica", "Ben", "Oliver", "Nick", "William", "Penny" };

            string[] SortStringArray(string[] Array)
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
            SortStringArray(StringArray);
            lblArrayString.Text = StringArray[0] + ", " + StringArray[1] + ", " + StringArray[2] + ", " + StringArray[3] + ", " + StringArray[4] + ", " + StringArray[5] + ", " + StringArray[6] + ", " + StringArray[7] + ", " + StringArray[8] + ", " + StringArray[9];
        }
    }
}
