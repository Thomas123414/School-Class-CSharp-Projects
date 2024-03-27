using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Task_19_XML_File
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string Song = txtSong.Text;
            string Genre = txtGenre.Text;
            int Duration = int.Parse(txtDuration.Text);
            string Record = txtRecord.Text;
            string Artist = txtArtist.Text;





            if (!File.Exists("Test.xml"))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();

                xmlWriterSettings.Indent = true;

                xmlWriterSettings.NewLineOnAttributes = true;

                using (XmlWriter xmlWriter = XmlWriter.Create("Test.xml", xmlWriterSettings))
                {

                    xmlWriter.WriteStartDocument();

                    xmlWriter.WriteStartElement("SongInfo");



                    xmlWriter.WriteStartElement("Song");

                    xmlWriter.WriteElementString("SongName", Song);

                    xmlWriter.WriteElementString("Genre", Genre);

                    xmlWriter.WriteElementString("Duration", Duration.ToString());

                    xmlWriter.WriteElementString("Record", Record);

                    xmlWriter.WriteElementString("Artist", Artist);

                    xmlWriter.WriteEndElement();



                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndDocument();

                    xmlWriter.Flush();

                    xmlWriter.Close();

                }
            }
            else
            {

                XDocument xDocument = XDocument.Load("Test.xml");

                XElement root = xDocument.Element("SongInfo");

                IEnumerable<XElement> rows = root.Descendants("Song");

                XElement firstRow = rows.First();

                firstRow.AddBeforeSelf(

                   new XElement("Song",

                   new XElement("SongName", Song),

                   new XElement("Genre", Genre),

                   new XElement("Duration", Duration.ToString()),
                   
                   new XElement("Record", Record),

                   new XElement("Artist", Artist)));

                xDocument.Save("Test.xml");

            }
            MessageBox.Show("Saved!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lsvOutput.Items.Clear();
            string sn = "", g = "", d = "", rl = "", a="";
            using (XmlReader reader = XmlReader.Create("Test.xml"))
            {

                while (reader.Read())
                {
                    // ListViewItem listItem = new ListViewItem();   //"Row" object.
                    if (reader.IsStartElement())
                    {

                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "SongName":       //Store the data element firstname 
                                sn = reader.ReadString();
                                break;
                            case "Genre":
                                g = reader.ReadString();
                                break;
                            case "Duration":
                                d = reader.ReadString();
                                break;
                            case "Record":
                                rl = reader.ReadString();
                                break;
                            case "Artist":
                                a = reader.ReadString();
                                //When all fields have been read - next element will be player 
                                //Add the row object to the listview.
                                ListViewItem listItem = new ListViewItem();   //"Row" object.
                                listItem.Text = sn;
                                listItem.SubItems.Add(g);
                                listItem.SubItems.Add(d);
                                listItem.SubItems.Add(rl);
                                listItem.SubItems.Add(a);
                                if (sn != "" && g != "" && d != "" && rl != "" && a != "")   //if field all have values
                                    lsvOutput.Items.Add(listItem);      //display entire listview row

                                break;

                        }

                    }

                }

            }
        }
    }
}
