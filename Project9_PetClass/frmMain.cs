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
 *  Program: Converting Distances
 *  Date: 03/11/2022
 *  Author: Chris D.
 *  Description: Basic class concept. 
 *  Inputting a user's information and storing
 *  in a class, then output to label. s
 * 
 * *****************************/

namespace Project9_PetClass
{
    public partial class frmMain : Form
    {

        //int petAge = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void GetPetData (pet pet)
        {
            int petAge = 0; //temp var to hold the age
            string petType = "";
            string petName = "";


            pet.Name = txtName.Text;
            pet.Type = txtType.Text;

            if (int.TryParse(txtAge.Text, out petAge))
            {
                pet.Age = petAge;
                lblDisplay.Text = "Name: " + pet.Name + "\n" +
                                "Type: " + pet.Type + "\n" +
                                "Age: " + pet.Age.ToString();

            }
            else
            {
                MessageBox.Show("Invalid age. Please enter the age properly.");
            }


        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //create pet object
            pet myPet = new pet();

            //get the pet data
            GetPetData(myPet);

            //display the pet data
            
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtType.Text = "";
            txtAge.Text = "";

            lblDisplay.Text = "";

            txtName.Focus();
        }
    }
}
