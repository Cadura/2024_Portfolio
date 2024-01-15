using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*******************************
 * 
 *  Program: Converting Distances
 *  Date: 02/02/2022
 *  Author: Chris D.
 *  Description: Computes a user's original distance to feet, 
 *  yard, or inches.
 * 
 * *****************************/

namespace _285_Project4_Converter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
        
                btnConvert_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double dblDistance; //var to store textbox input to convert
            double dblResult; //to store the converted value and then convert it back to string

            try
            {

                dblDistance = double.Parse(txtEnterDist.Text); //get the textbox input value


                if (lstFrom.SelectedIndex == 0) //FROM INCHES
                {
                    if (lstTo.SelectedIndex == 0) //to inches
                    {
                        lblResult.Text = txtEnterDist.Text; //SAME VALUE
                    }
                    else if (lstTo.SelectedIndex == 1) //to feet
                    {
                        dblResult = dblDistance / 12;
                        lblResult.Text = dblResult.ToString("n5");
                    }
                    else //(lstTo.SelectedIndex == 2) //to yards
                    {
                        dblResult = dblDistance / 36;
                        lblResult.Text = dblResult.ToString("n5");
                    }
                }

                else if (lstFrom.SelectedIndex == 1) //FROM FEET
                {
                    if (lstTo.SelectedIndex == 0) //to inches
                    {
                        dblResult = dblDistance * 12;
                        lblResult.Text = dblResult.ToString();
                    }
                    else if (lstTo.SelectedIndex == 1) //to feet
                    {
                        lblResult.Text = txtEnterDist.Text; //SAME VALUE
                    }
                    else //(lstTo.SelectedIndex == 2) //to yards
                    {
                        dblResult = dblDistance / 3;
                        lblResult.Text = dblResult.ToString("n5");
                    }
                }

                else //(lstFrom.SelectedIndex == 2) //FROM YARDS
                {
                    if (lstTo.SelectedIndex == 0) //to inches
                    {
                        dblResult = dblDistance * 36;
                        lblResult.Text = dblResult.ToString();
                    }
                    else if (lstTo.SelectedIndex == 1) //to feet
                    {
                        dblResult = dblDistance * 3;
                        lblResult.Text = dblResult.ToString();
                    }
                    else //if (lstTo.SelectedIndex == 2) //to yards
                    {
                        lblResult.Text = txtEnterDist.Text; //SAME VALUE
                    }
                }

                /*else if (lstFrom.SelectedIndex == -1 || lstTo.SelectedIndex == -1) //when the units not selected 
                {
                    MessageBox.Show("Select the units", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }*/
            }//try

            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message.ToString());
                txtEnterDist.Focus();
                txtEnterDist.SelectAll();
            }//catch
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //default selection
            lstFrom.SelectedIndex = 0;
            lstTo.SelectedIndex = 1;
        }
    }
}
