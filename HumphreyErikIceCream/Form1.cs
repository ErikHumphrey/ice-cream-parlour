/*
 _____               _____                               
|_   _|             /  __ \                              
  | |    ___   ___  | /  \/ _ __   ___   __ _  _ __ ___  
  | |   / __| / _ \ | |    | '__| / _ \ / _` || '_ ` _ \ 
 _| |_ | (__ |  __/ | \__/\| |   |  __/| (_| || | | | | |
 \___/  \___| \___|  \____/|_|    \___| \__,_||_| |_| |_|
                                                         
*/ 

/* Author: Erik Humphrey
 * Project title: Project 14 - Ice Cream
 * Date finished: November 20th
 * Executable name: HumphreyErikIceCream.exe
 * Description: Displays an invoice for an ice cream order based on prices based on user choices.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErikIceCream
{
    public partial class frmIceCreamParlour : Form // Using Canadian spelling conventions for parlo(u)r and flavo(u)r
    {
        public frmIceCreamParlour()
        {
            InitializeComponent();
            cboContainer.Text = "Select a container";
        }

        private void frmIceCreamParlour_Load(object sender, EventArgs e)
        {
            // Add flavours to listbox
            lstSelectFlavour.Items.Add("Chocolate");
            lstSelectFlavour.Items.Add("Chocolate chip cookie dough");
            lstSelectFlavour.Items.Add("Cookies and cream");
            lstSelectFlavour.Items.Add("Mint chocolate chip");
            lstSelectFlavour.Items.Add("Pistachio");
            lstSelectFlavour.Items.Add("Strawberry");
            lstSelectFlavour.Items.Add("Vanilla");
            lstSelectFlavour.SelectedItem = "Chocolate"; // Set the default selected flavour
        }

        // Show spoon icon and disable adding toppings if Sample size is checked

        private void radSizeSample_CheckedChanged(object sender, EventArgs e)
        {
            picSampleSpoon.Visible = true;
            cboContainer.Visible = false;
            chkBlackberries.Enabled = false;
            chkCandyHearts.Enabled = false;
            chkCherries.Enabled = false;
            chkChocolate.Enabled = false;
            chkPeanuts.Enabled = false;
            chkSprinkles.Enabled = false;
            chkBlackberries.Checked = false;
            chkCandyHearts.Checked = false;
            chkCherries.Checked = false;
            chkChocolate.Checked = false;
            chkPeanuts.Checked = false;
            chkSprinkles.Checked = false;
            cboContainer.SelectedIndex = -1;
        }

        // Hide spoon icon and enable adding toppings if Sample size is unchecked

        private void radSizeSample_Unchecked(object sender, EventArgs e)
        {
            picSampleSpoon.Visible = false;
            cboContainer.Visible = true;
            chkBlackberries.Enabled = true;
            chkCandyHearts.Enabled = true;
            chkCherries.Enabled = true;
            chkChocolate.Enabled = true;
            chkPeanuts.Enabled = true;
            chkSprinkles.Enabled = true;
            cboContainer.Text = "Select a container";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Make sure container, flavour, and size are selected before proceeding with order
            if (!radSizeSample.Checked && cboContainer.SelectedIndex == -1) // Ignore the lack of container selection if sample is checked
                MessageBox.Show("Please select a container.", "No container", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lstSelectFlavour.SelectedIndex == -1)
                MessageBox.Show("Please select a flavour.", "No flavour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!radSizeSample.Checked && !radSizeSmall.Checked && !radSizeMedium.Checked && !radSizeLarge.Checked)
                MessageBox.Show("Please select a size.", "No size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Calculate price. Flavour and container choice do not affect price.
                double price = 0; // Also resets price to 0 if multiple orders are made

                // Initial price based on serving size. radSizeSample is a free sample, so it's not set to 0 here.
                if (radSizeSmall.Checked)
                    price = 1.25;
                if (radSizeMedium.Checked)
                    price = 1.60;
                if (radSizeLarge.Checked)
                    price = 2.25;
                // Add to price for to
                if (chkPeanuts.Checked)
                    price = price + 0.4;
                if (chkChocolate.Checked)
                    price = price + 0.4;
                if (chkBlackberries.Checked)
                    price = price + 0.4;
                if (chkSprinkles.Checked)
                    price = price + 0.4;
                if (chkCherries.Checked)
                    price = price + 0.4;
                if (chkCandyHearts.Checked)
                    price = price + 0.4;

                // Add the price (converted to a currency value) to a purchase confirmation
                string purchaseConfirmed = "Your credit card has been charged." + "\r\nTotal: " + price.ToString("C");
                if (price == 0)
                    purchaseConfirmed = "Enjoy your free sample!"; // ...or remind user that there's no cost to sample flavours!

                lblNoToppings.Text = "";

                // new thing to learn about: LINQ IEnumerable OfType
                // Variable that is the control with the checked Size group RadioButton
                var checkedSize = grpServingSize.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                /* Variable that is a list of controls with the checked Toppings group CheckBox
                 * A line break and tab is put in between each topping
                 * Comma and space also works well, but would have to convert first char of every item but first to lower */
                var checkedToppings = String.Join("\r\n\t", grpToppings.Controls.OfType<CheckBox>().Where(r => r.Checked).Select(r => r.Text));

                if (checkedToppings == "")
                {
                    lblNoToppings.Text = "None"; // Did it like this because of a Visual Studio bug
                }

                string container;
                if (radSizeSample.Checked)
                    container = "A spoon";
                else
                    container = Convert.ToString(cboContainer.SelectedItem);

                MessageBox.Show(
                    grpServingSize.Text + ": " + checkedSize.Text // Add serving size
                    + "\r\n"
                    + lblTitleContainer.Text + ": " + container // Add container
                    + "\r\n"
                    + lblTitleFlavour.Text + ": " + lstSelectFlavour.SelectedItem // Add flavour
                    + "\r\n"
                    + grpToppings.Text + ": " + checkedToppings + lblNoToppings.Text // List of toppings
                    + "\r\n\r\n"
                    + purchaseConfirmed,
                    "Thank you", // MessageBox title
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk
                    );
            }
        }
    }
}
