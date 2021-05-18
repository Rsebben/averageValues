using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace averageValues
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int numOfValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            numOfValue = 0;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double average;
            int input = Convert.ToInt32(numberInput.Text);
            //get the input from the user

            if(input > 0)
            {
                sum = sum + input;
                numOfValue++;
                // show the value that was added in the output
                sumOutput.Text = $"{input} was added to sum";
            }
            else
            {
                //calc average = sum / numOfValues;
                average = sum / numOfValue;

                //show average to output
                sumOutput.Text = $"The average of all the numbers entered is: {average}";
            }

        }
    }
}
