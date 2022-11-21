using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeddoreLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Name: Nicholas Jeddore
        * Date: October 2, 2022
        * Description: This program is lab 2 in this course. Essentially there are two groupboxes that do
        * two different things. The left groupbox does a simple calculation with integers and displays it. The
        right groupbox can show a picture and data about the topic of the picture which is my dog, and 
        lastly there is an exit button in this right groupbox. */
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //hide the large data label
            lblData.Hide();

            //show the picture
            picImage.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //hide both the large data label and picture
            lblData.Hide();
            picImage.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //blank out the two textboxes and one label in the left groupbox
            txtNumber.ResetText();
            txtMultiplier.ResetText();
            lblAnswer.ResetText();

            //put focus on the top textbox
            txtNumber.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //declare string with concatenation to put in the data label
            string jasperData = "My topic is on Jasper, who is our family dog.\n\n" +
                "He is a 3 year old chocolate labrador.\n\n" +
                "His favourite activities are walking, swimming, and playing tug of war.\n\n" +
                "His favourite human food are honey dip and plain flavoured Timbits from Tim Hortons.";

            //hide picture
            picImage.Hide();

            //put the string into the data label
            lblData.Text = jasperData;

            //show large data label
            lblData.Show();
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            //display messagebox with some info and name in title
            MessageBox.Show("This picture of Jasper was taken by me this past summer while outdoors.", "Nicholas Jeddore");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare three local integer variables
            int number, multiplier, answer;

            //convert text from number textbox to an int and set the number variable to it
            number = Convert.ToInt32(txtNumber.Text);
            
            //convert text from multiplier textbox to an int and set the multiplier variable to it
            multiplier = Convert.ToInt32(txtMultiplier.Text);

            //set answer to this simple multiplication formula
            answer = number * multiplier;

            //convert answer to string and display it in the answer label
            lblAnswer.Text = answer.ToString();
        }
    }
}
