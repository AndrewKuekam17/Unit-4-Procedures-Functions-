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

namespace VolumeofaCylinderAndrew
{
    public partial class frmVolumeOfACylinder : Form
    {
        public frmVolumeOfACylinder()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            // declare local variables
            double Volume = 0;
            double Radius = 0;
            double Height = 0;

            // Convert the string from eachtext box
            Radius = double.Parse(txtHeight.Text);
            Height = double.Parse(txtRadius.Text);

            //calculate the Volume of the cylinder
            Volume = 3.14 * Radius * Radius * Height;

            // display the Volume on the lable
            this.lblAnswer.Text = " The Volume is: " + Volume;

            //this show the lblAnswer
            this.lblAnswer.Show();

        }

        private void frmVolumeOfACylinder_Load(object sender, EventArgs e)
        {
            //this the lblAnswer, Height ,Radius
            this.lblAnswer.Hide();
            this.lblHeight.Show();
            this.lblRadius.Show();
            this.btnCalculator.Show();
        }
    }
}
