using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*******************************
 * 
 *  Program: Number Guesser
 *  Date: 02/07/2022
 *  Author: Chris D.
 *  Description: A number guesser game where a computer 
 *  generates a random number. The user will guess
 *  a number, and the computer will respond higher or lower 
 *  until it hits the mark.
 * 
 * *****************************/
namespace Project5_NumberGuesser
{
    public partial class frmMain : Form
    {
        //variables
        int number = 0;
        int guess = 0;
        int guessedNum = 0;

        //create random number
        Random randNum = new Random();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            guess = Convert.ToInt32(txtEnterNumber.Text); //convert the string to number

            if (guess == number) //when the guess number is correct
            {
                MessageBox.Show("You've guessed it!");
                txtEnterNumber.Text = "";
                guessedNum += 1; //increment the guessed number
                lblGuessedResult.Text = guessedNum.ToString(); //display guessed number
                //reset the number
                Random randNum = new Random();
                number = randNum.Next(1, 100);
                txtEnterNumber.Focus();
                txtEnterNumber.SelectAll();


            }
            else if (guess < number) //when the guess number is lower
            {
                MessageBox.Show("HIGHER!");
                txtEnterNumber.Focus();
                txtEnterNumber.SelectAll();
            }
            else //when the guess number is higher
            {
                MessageBox.Show("LOWER!");
                txtEnterNumber.Focus();
                txtEnterNumber.SelectAll();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //random integer from 1 to 100
            number = randNum.Next(1, 100);
        }
    }
}
