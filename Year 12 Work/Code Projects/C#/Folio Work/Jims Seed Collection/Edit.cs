using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jims_Seed_Collection
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        public string path = "SeedCollection.txt";
        public string[] lines = File.ReadAllLines("SeedCollection.txt");
        public int selected_index = Form1.selected_ID;                 //Get the selected index of the listview object from the previous form
        public string ID;


        private void Edit_Load(object sender, EventArgs e)
        {
            string[] items = lines[selected_index].Split(',');
            ID = items[0];
            txtTitle.Text = items[1];
            txtLocation.Text = items[2];
            txtNumber.Text = items[3];
            txtValue.Text = items[4];
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string record = ID + "," + txtTitle.Text + "," + txtLocation.Text + "," + txtNumber.Text + "," + txtValue.Text;  //ID will be the same as before. The other fields can be changed
            lines[selected_index] = record;                                                        //Overwrite the record to be edited with new values
            File.WriteAllLines(path, lines);                                                      //Update the text file with new edited array (lines)
            MessageBox.Show("Saved!");
        }
    }
}
