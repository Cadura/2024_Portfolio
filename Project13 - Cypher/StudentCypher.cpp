//Simple Caesar Cypher Program

#include <iostream>
#include <iomanip>
#include <string>
#include <windows.h>  
#include <cmath>

#undef max //Fixes undefined max when deleting cin errors - or also known as bad input.

using namespace std;

/*
using std::cout;
using std::cin;
using std::endl;
using std::string;*/

//function prototypes
string encrypt(string strText, int asciiShift, bool encryptMode);

int main()
{
	//boolean switch from encryption first, but eventually decryption
	bool encryptMode = true;
	int ascShift = 0;	 //shift in ASCII code by this many positions	
	string strText = ""; //holds the cypher or the plain text	

	cout << "Welcome to Ceaser's Cipher Machine!" << endl;
	cout << "-----------------------------------" << endl << endl;

	cout << "Please enter the text to be enciphered: ";
	getline(cin, strText);

	cout << endl << endl;	

		do {
			
			//create a post test while loop to validate the range here
			//if the value entered falls outside of the acceptable range, keep looping until it doens't
			cout << "Please enter the positional shift value (integer from 1 to 255 inclusive): ";
			cin >> ascShift;

			if (!cin) 
			{
				cin.clear();
				cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); //skip bad input - delete that input. Then new line('\n')
			}

			if (ascShift < 1 || ascShift > 255) {
				cout << "Error" << endl;
			}

		} while (ascShift < 1 || ascShift > 255);


	cout << endl << endl;

	//call the encrypt() function to encrypt the string
	strText = encrypt(strText, ascShift, encryptMode);
	cout << "Encrypted text: " << strText << endl << endl << endl;
	//switch the function from encryptionMode to decryption mode
	encryptMode = false;
	strText = encrypt(strText, ascShift, encryptMode);
	//call the encrypt() function again to decrypt the string back into plain text
	cout << "Decrypted text: " << strText << endl << endl << endl;

 	system("pause");

	return 0;

}   //end of main function

//function definition
string encrypt(string strText, int asciiShift, bool encryptMode)
{
	int i = 0; //string index counter
	int asciiValue = 0; //holds ASCII character numeric value of current character in string
	string asciiChar = ""; //holds the new shifted ASCII character

	if (encryptMode == false) { // decrypt mode


		//loop through each character in the string	[HINT] Use s.length - 1 for the loop counter max value and treat the string like a 1D array
		while (i <= strText.length() - 1)
		{

			//STEP 1: get the ASCII value of current character in the string
			asciiValue = strText[i];

			//STEP 2: add or subtract the offset value to the current ASCII value then convert into the new character
			asciiValue -= asciiShift;
			if (asciiValue <= 0) {
				asciiValue += 255;
			}

			asciiChar = asciiValue;

			//STEP 3: at the current poisiton in the string, "replace" the old character with new character
			strText.replace(i, 1, asciiChar);
			i++;
		}
	}
	else if (encryptMode == true) { // encryption mode
		while (i <= strText.length() - 1)
		{

			//STEP 1: get the ASCII value of current character in the string
			asciiValue = strText[i];
			//STEP 2: add or subtract the offset value to the current ASCII value then convert into the new character
			asciiValue += asciiShift;
			if (asciiValue > 127) {
				asciiValue -= 255;
			}
			asciiChar = asciiValue;

			//STEP 3: at the current poisiton in the string, "replace" the old character with new character
			strText.replace(i, 1, asciiChar);
			i++;
		}
	}
	return strText;
}


