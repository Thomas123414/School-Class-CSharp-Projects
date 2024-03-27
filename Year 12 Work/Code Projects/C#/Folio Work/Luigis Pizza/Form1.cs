using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luigis_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisOrd_Click(object sender, EventArgs e)
        {
            Boolean existence = true;
            Boolean typeCheck = true;

            Regex objAlphaPattern = new Regex("[a-zA-Z][a-zA-Z]");
            Regex objNumberPattern = new Regex("[0-9.-]$");

            if (!objAlphaPattern.IsMatch(txtName.Text) || !objAlphaPattern.IsMatch(CBPizza.Text))        //If the name is not made up of letters
            {
                typeCheck = false;
            }
            if (!objNumberPattern.IsMatch(txtCard.Text) || !objNumberPattern.IsMatch(TxtNumPizza.Text))       //if the card numbers are not numbers
            {
                typeCheck = false;
            }

            if ((txtCard.Text == "") || (txtName.Text == "") || (CBPizza.Text == "") || (TxtNumPizza.Text == ""))
            {
                existence = false;
                MessageBox.Show("Invalid input. Please input all field values.");
            }
            else if (Radsmall.Checked == false)
            {
                if (Radmedium.Checked == false)
                {
                    if (Radlarge.Checked == false)
                    {
                        existence = false;
                        MessageBox.Show("Invalid input. Please input all field values.");
                    }
                }
            }

            if (typeCheck == false)
            {
                MessageBox.Show("Make sure all fields are of the correct type");
            }

            if ((existence == true) && (typeCheck == true))
            {
                lstorder.Items.Clear();
                double TotalCost = 0;
                double Cost = 0;
                lstorder.Items.Add("Order Details: ");

                lstorder.Items.Add("Customer Name: " + txtName.Text);
                lstorder.Items.Add("Pizza Ordered: " + CBPizza.Text);
                string Size = Radsmall.Checked ? "Small" : Radmedium.Checked ? "Medium" : "Large";
                lstorder.Items.Add("Size Of Pizza: " + Size);

                List<string> extras = new List<string>();

                if (CBoxcheese.Checked)
                {
                    extras.Add("Cheese");
                    TotalCost = TotalCost + 1;
                }

                if (CBoxham.Checked)
                {
                    extras.Add("Ham");
                    TotalCost = TotalCost + 1.5;
                }

                if (CBoxchilli.Checked)
                {
                    extras.Add("Chilli");
                    TotalCost = TotalCost + 0.8;
                }

                if (extras.Count > 0)
                {
                    string extrasString = string.Join(", ", extras);
                    lstorder.Items.Add($"Extras: {extrasString}");
                }
                else
                {
                    lstorder.Items.Add("Extras: None");
                }
                if (Radsmall.Checked == true)
                {
                    TotalCost = TotalCost + 8;
                }
                else if (Radmedium.Checked == true)
                {
                    TotalCost = TotalCost + 12;
                }
                else if (Radlarge.Checked == true)
                {
                    TotalCost = TotalCost + 16;
                }
                int NumOfPizzas = Int32.Parse(TxtNumPizza.Text);
                lstorder.Items.Add("Amount Of Pizzas: " + NumOfPizzas);
                Cost = TotalCost * NumOfPizzas;
                lstorder.Items.Add("The Cost of your order: " + "$" + Cost);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}