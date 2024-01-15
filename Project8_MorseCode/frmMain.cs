using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8_Morse_Code
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region "properties"
        //properties
        char[] morseCharacters =
        {
            ' ', ',', '.', '?', '0', '1', '2', '3', '4', '5', '6', '7', '8',
            '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        string[] morseCode =
        {
            "   ", "--..--", ".-.-.-", "..--..", "-----", ".----", "..---", "...--",
            "....-", ".....", "-....", "--...", "---..", "----.", ".-", "-...", "-.-.", "-..",
            ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };
        #endregion

        #region "Exit Button"
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Convert Button"
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string userMessaage = txtMessage.Text; //string for user's input message
            userMessaage = userMessaage.ToUpper(); //convert input message to uppercase
            char[] ch = userMessaage.ToCharArray(); //store user's input message to char array
            string strResult = ""; //empty string to store the converted result


            for (int x = 0; x < ch.Length; x++) //loop through the ch array (user's input)
            {
                for (int y = 0; y < morseCharacters.Length; y++) //morseCharacter array
                {
                    if (morseCharacters[y] == ch[x]) //compare and match the character array with user input array
                    {
                        strResult = morseCode[y]; //assign the morse code array to string result                        }
                    }
                }

                lblOutCode.Text += strResult + ' '; //display the morse code

            }

        }
        #endregion

        #region "Reset Button"
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            lblOutCode.Text = "";
            txtMessage.Focus();
        }



        #endregion

        #region "Keypressed in Textbox"
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            lblOutCode.Text = "";
        }
        #endregion

    }
}
