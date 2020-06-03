/*
 * Created by: Andrew Kuekam
 * Created on: 2020-06-01
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
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

namespace StringEqualityAndrew
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }
        private bool IsEqual (string stringA, string stringB)
        {
            // declare local variables
            bool stringAreEqual = false;

            // compare the length of each string
            if (stringA.Length == stringB.Length)
            {
                // Convert both string to lower case
                string stringALower = stringA.ToLower();
                string stringBLower = stringB.ToLower();

                //if both string are equal then set bool to trua
                if (stringALower == stringBLower)
                {
                    stringAreEqual = true;
                }
            }

            // return the boolean
            return stringAreEqual;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare variables
            String userString1;
            String userString2;
            bool stringAreEqual;

            // Convert to String toa double
            userString1 = txtString1.Text;
            userString2 = txtString2.Text;

            //call the function that will determine if the strings are equal
            stringAreEqual = IsEqual(userString1, userString2);

            if( stringAreEqual == true )
            {
                MessageBox.Show(" These strings are equal.");
            }
            else if (stringAreEqual == false)
            { 
                MessageBox.Show(" These strings NOT are equal.");
            }

        }
    }
}
