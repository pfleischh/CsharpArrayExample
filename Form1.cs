using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Author: Peter Fleischhacker
 * Date: 4/1/19
 * Topic Review - Arrays
 */

namespace FlePTopicReviewArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // loads ProcessArray function at form load
            ProcessArray();
        }

       

        
        public void ProcessArray()
        {
          //  Random num = new Random();
            //create 5x5 2d array called numArray
            int[,] numArray = new int[5, 5];
       
            Random num = new Random();

            // int to hold the numbers
            int tempNum;

            // string to hold the random numbers before putting them in txtNumbers box
            string temp = "";

            
            // for loop to set random numbers between 1 and 50 to array
            for (int x = 0; x < numArray.GetLength(0); x++)
            {
                for (int y = 0; y < numArray.GetLength(1); y++)
                {
                    tempNum = num.Next(0, 50);
                    numArray[x, y] = tempNum;
                    temp += tempNum.ToString() + "\t";
                }
                if (x < numArray.GetLength(0) - 1) temp += "\r\n" ;

                // find the smallest number in the array 
                int smallest = numArray.Cast<int>().Min();

                // display smallest number in txtSmallestNumber text box
                txtSmallestNumber.Text = "Smallest number is " + smallest.ToString() + ".";

                // display the number of times the smallest number appears in txtCountSmallNumb
              //  int count;

                    
              //  txtCountSmallNumb.Text = "Found " + count.ToString() + " time(s) in these coords:";

                // display the coordinates of where the smallest number appears in the array in txtArrayLocation
               // txtArrayLocation.Text = ;
            }
            // display numbers in text box txtNumbers
            txtNumbers.Text = temp;



        }

        private void btnGetNewNumbers_Click(object sender, EventArgs e)
        {
            // call ProcessArray() to get new numbers
            ProcessArray();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }
    }
}
