using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlist_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string song = txtsong.Text;
            string genre = cbogenre.Text;
            string artist = txtartist.Text;
            string duration = txtduration.Text;
            string record = song + ", " + genre + ", " + artist + ", " + duration;

            string path = @"C:\temp\class.txt";

            using (TextWriter tw = new StreamWriter(path, true))
            {
                tw.WriteLine(record);
            }
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\temp\class.txt");
            foreach (string line in lines)
            {
                lstfile.Items.Add(line);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lstfile.Items.Clear();
            txtsong.Text = "";
            cbogenre.Text = "";
            txtartist.Text = "";
            txtduration.Text = "";
        }
    }
}
