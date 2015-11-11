/*
 * Created by: Alex Mathias
 * Created on: 11-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-01
 * This program displays an array between 1 and 10
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

namespace RandomNumberArray
{
    public partial class frmRandomNumberArray : Form
    {
        // global variables
        int[] arrayOfNumbers = new int[10];
        public frmRandomNumberArray()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //Variables
            int loopCounter = 0;
            int average = 0;
            int randomNumbers;
            Random rnd = new Random();

            while (loopCounter < 10)
            {
                randomNumbers = rnd.Next(1, 11);
                arrayOfNumbers[loopCounter] = randomNumbers;
                this.lstArray.Items.Add(arrayOfNumbers[loopCounter]);
                average = average + arrayOfNumbers[loopCounter];
                loopCounter++;
            }

            average = average / 10;
            this.lblAverage.Text = "The average is " + average;

        }
    }
}
