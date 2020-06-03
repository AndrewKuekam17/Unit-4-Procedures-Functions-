/*
 * Created by: Andrew Kuekam
 * Created on: 2020-05-27
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
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

namespace CalculateTheHypotenuseAndrew
{
    public partial class frmCalculatetheHypotenuse : System.Windows.Forms.Form
    {
        public frmCalculatetheHypotenuse()
        {
            InitializeComponent();
        }

        private void frmCalculatetheHypotenuse_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            // declare local variables
            double hypotenuse = 0;
            double aLeg = 0;
            double bLeg = 0;

            // Convert the string from each text box
            aLeg = double.Parse(txtALeg.Text);
            bLeg = double.Parse(txtBLeg.Text);

            // Calculate the Hypotenuse
            hypotenuse = Math.Sqrt(aLeg * aLeg + bLeg * bLeg);

            //Display the Hypo on the lbl
            this.lblAnswer.Text = " The Hypotenuse is: " + hypotenuse; 

        }
    }
}
