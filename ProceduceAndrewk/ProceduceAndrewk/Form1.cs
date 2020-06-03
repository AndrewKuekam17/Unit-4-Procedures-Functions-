/*
 * Created by: Andrew kuekam
 * Created on: 2020-05-22
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Area Procedure
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

namespace ProceduceAndrewk
{
    public partial class frmAreaProcedure : Form
    {
        public frmAreaProcedure()
        {
            InitializeComponent();
        }
        // Function: Degrees celsius
        // Input: UserCelsius
        // Output:void 
        public void Calculatefahrenheit(int Celsius)
        {
            // declare local varibles
            int fahrenheit;

            // Calculate the The Degrees celsius.
            fahrenheit = Celsius * (int) 9/ (int) 5 + 32;

            // Display a message box with the calculate fahrenheit
            MessageBox.Show(" The Degrees celsius: " + fahrenheit + " Degrees fahrenheit.");
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //Declare local variable
            int UserCelsius;

            // convert the celsius to int 
            UserCelsius = Convert.ToInt16(this.txtCelsius.Text);

            // call the function to calculate celsius
            this.Calculatefahrenheit(UserCelsius);

        }
    }
}
