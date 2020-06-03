/*
 * Created by: Andrew Kuekam
 * Created on: 2020-06-01
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Round By Ref
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

namespace RoundByRefAndrew
{
    public partial class frmRoundByRef : Form
    {
        public frmRoundByRef()
        {
            InitializeComponent();
        }

        private void Round(ref double userNumber, int userNumDecimal)
        {
            // multiply number by 10 to power of how many decimal points you want
            userNumber = userNumber * Math.Pow(10, userNumDecimal);

            // add 0.5
            userNumber = userNumber + 0.5;

            // get rid of numbers following the decimal(i.e.Math.Truncate)
            userNumber = Math.Truncate(userNumber);

            // move decimal point back to its original place
            userNumber = userNumber / Math.Pow(10, userNumDecimal);

        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            // declare variables
            double theNumber;
            int numDecimal;

            // convert the user value to a Double
            theNumber = double.Parse(txtNumber.Text);
            numDecimal = (int)nudnumDecimal.Value;

            //call the function to round the number of decimal places
            Round(ref theNumber, numDecimal);

            // display the rounded number
            MessageBox.Show(" The rounded Answer is: " + theNumber);



        }
    }
}
