/*
 * Created by: Andrew Kuekam
 * Created on: 2020-05-27
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Percentage Program
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

namespace SwitchStateAndrew
{
    public partial class frmSwitchStatement : Form
    {
        public frmSwitchStatement()
        {
            InitializeComponent();
        }

        //Function: ConvertToPercent
        // Input: Sring level
        // OutPut:int
        private int ConvertToPercent(String Level)
        {
            int percentage = -1;

            switch (Level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 85;
                    break;
                case "4-":
                    percentage = 80;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }
            return percentage;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare variables
            String level;
            int percent;

            // get level from to text
            level = this.txtGrade.Text;

            // call the function that will convert the level to a percent
            percent = ConvertToPercent(level);

            if (percent == +4)
            {
                MessageBox.Show(" Please enter a valid level.");
            }
            else if (percent == +3)
            {
                MessageBox.Show(" Please enter a valid level.");
            }  
            else if (percent == -1)
            {
                MessageBox.Show(" Please enter a valid level.");
            }
            else if (percent == +2)
            {
                MessageBox.Show(" Please enter a valid level.");
            }
            // Display the percentage to the user
            MessageBox.Show(" level " + level + " is equivalent to " + percent + " %. ");

        }
    }
}
