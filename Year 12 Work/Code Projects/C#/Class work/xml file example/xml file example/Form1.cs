using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace xml_file_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname = txtFName.Text;
            string surname = txtSName.Text;
            string age = txtAge.Text;
            string no = txtNumber.Text;


            if (!File.Exists("Soccer.xml"))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("Soccer.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("ALPlayers");

                    xmlWriter.WriteStartElement("Player");
                    xmlWriter.WriteElementString("FirstName", firstname);
                    xmlWriter.WriteElementString("SurName", surname);
                    xmlWriter.WriteElementString("Age", age);
                    xmlWriter.WriteElementString("PlayerNumber", no);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load("Soccer.xml");
                XElement root = xDocument.Element("ALPlayers");
                IEnumerable<XElement> rows = root.Descendants("Player");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Player",
                   new XElement("FirstName", firstname),
                   new XElement("SurName", surname),
                   new XElement("Age", age),
                   new XElement("PlayerNumber", no)));
                xDocument.Save("Soccer.xml");
            }

        }

        private void btnDisplayFile_Click(object sender, EventArgs e)
        {








           string fn = "", sn = "", age = "", d = "";
            using (XmlReader reader = XmlReader.Create("Soccer.xml"))
            {

                while (reader.Read())
                {
                    // ListViewItem listItem = new ListViewItem();   //"Row" object.
                    if (reader.IsStartElement())
                    {

                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        { 
                            case "FirstName":       //Store the data element firstname 
                                fn = reader.ReadString();
                                break;
                            case "SurName":
                                sn = reader.ReadString();
                                break;
                            case "Age":
                                age = reader.ReadString();
                                break;
                            case "PlayerNumber":
                                d = reader.ReadString();
                                break;
                            case "Player":                        //When all fields have been read - next element will be player 
                                //Add the row object to the listview.
                                ListViewItem listItem = new ListViewItem();   //"Row" object.
                                listItem.Text = fn;
                                listItem.SubItems.Add(sn);
                                listItem.SubItems.Add(age);
                                listItem.SubItems.Add(d);
                                if (fn != "" && sn != "" && age != "" && d != "")   //if field all have values
                                    lsvOutput.Items.Add(listItem);      //display entire listview row

                                break;

                        }

                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // lsvOutput.Items.Add(listItem);

        }
    }
}