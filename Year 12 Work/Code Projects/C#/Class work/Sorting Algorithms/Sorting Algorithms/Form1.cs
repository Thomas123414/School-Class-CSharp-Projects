using Microsoft.VisualBasic.Logging;
using System.Collections.Concurrent;

namespace Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] ages = { 1, 9, 7, 8, 5, 6, 4, 3, 10, 2, 100, 3 };

       private static void quicksort(int[] Array, int low, int high)
        {
            int p;
             if(low < high)
            {
                p = partition(Array, low, high);
                quicksort(Array, low, p-1);
                quicksort(Array, p+1, high);
            }
        }


        private static int partition(int[] A, int lo, int hi)
        {

            int temp;
            int pivot = A[hi];

            // index of smaller element 
            int i = (lo - 1);
            for (int j = lo; j <= hi - 1; j++)
            {

                // If current element is 
                // smaller than or 
                // equal to pivot 
                if (A[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] 
            // (or pivot) 
            temp = A[i + 1];
            A[i + 1] = A[hi];
            A[hi] = temp;

            return i + 1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int high = ages.Length - 1;
            quicksort(ages,0,high);

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (int i in ages)
            {
                lstOutput.Items.Add(i.ToString());
            }
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int n = ages.Length;
            int i;
            int j;
            int smallest;
            int temp = 0;

            for (i = 0; i <= n - 2; i++)
            {
                smallest = i;

                for (j = i + 1; j <= n - 1; j++)
                {
                    if (ages[j] < ages[smallest])
                    {
                        smallest = j;
                    }
                }
                if (smallest != i)
                {
                    temp = ages[smallest];
                    ages[smallest] = ages[i];
                    ages[i] = temp;

                }

            }
        }
    }
}