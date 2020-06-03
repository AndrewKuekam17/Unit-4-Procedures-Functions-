/*
 * Created by: Andrew Kuekam
 * Created on: 2020-05-25
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Optional Paramater
 * This program...
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

namespace OptionalParametresAndrewK
{
    public partial class frmOptionalParametersFrom : Form
    {
        public frmOptionalParametersFrom()
        {
            InitializeComponent();
        }

        public void PrintName(String AddressName, String userCity, String userPostalCode, String userProvince)
        {
            MessageBox.Show ("Your Address is: " + AddressName + " " + userCity + " " + userPostalCode + " " + userProvince);
        }

        // Proceduce: PrintName
        // Input: String fristName, string lastName
        // Output; void
        // Description: This produce display a message box with the given two parameter: first and last name.

        public void PrintName(String AddressName, String userPostalCode)
        {
            MessageBox.Show (" Your address is: " + AddressName + " " + userPostalCode);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Declare local variables
            String userAddressName, userUnitName, userCity, userPostalCode, userProvince;

            // get names from from taxt boxes
            userAddressName = this.txtAddress.Text;
            userUnitName = this.txtUnit.Text;
            userCity = this.txtCity.Text;
            userPostalCode = this.txtPostalCode.Text;
            userProvince = this.txtProvince.Text;

            // make the user a Address Name
            if (userAddressName == " ")
            {
                MessageBox.Show(" Please enter your AddressName. ", " Full Address Program");
            }
            // make the user enter a City Name
            else if (userCity == " ")
            {
                MessageBox.Show(" Please enter your City Name. ", " Full City Program");
            }
            // make the user enter a Postal Name
            else if (userPostalCode == " ")
            {
                MessageBox.Show(" Please enter your Postal Code Name. ", " Full Postal Code Program");
            }
            // make the user enter a Postal Name
            else if (userProvince == " ")
            {
                MessageBox.Show(" Please enter your Province Name. ", " Full Province Code Program");
            }
            // if the does not enter a UnitName, call the proceduce that accepts only 2 String parameters
            else if (userUnitName == " ")
            {
                PrintName(userAddressName, userCity, userPostalCode, userProvince);
            }
            // if the user enter all three names, call the  proceduce that accepts all 3  String parameters
            else
            {
                PrintName(userAddressName, userPostalCode, userCity, userProvince);

            }
        }
    }
}
