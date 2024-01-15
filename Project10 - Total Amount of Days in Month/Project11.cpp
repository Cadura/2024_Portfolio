#include <iostream>
#include <iomanip>

// Author: Christopher Duran
// Date: 10/28/2022
// Description: Displaying the total days of the month
// Concept: Using an array to store multiple variables of data, and utilitzing them
// for decision-making.

using namespace std;

void CalculateLeapYear(int days);
char QuitProgram();


void main()
{	// declarations
	int n = 0; // User's input number
	char quit; // quit program variable

	// array holds the days in 12-item list array(12 months).
	int DaysInMonth[12] = {30, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};


	do {
		system("cls");
		// input validation for months 
		do {
			cout << "Input the month number (between 1 - 12): ";
			cin >> n;

			/* n is a number, so if cin aka input does not take in a number,
			 then it fails. This if-statements catches that fail and resets. */

			if (!cin) // or if (cin.fail()) if (cin == false)
			{
				// user didn't input a number
				cin.clear(); // reset failbit - reset the stream
				cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); //skip bad input - delete that input. Then new line('\n')

			}
			// error message when input is not between 1 and 12.
			if ((n < 1) || (n > 12)) {
				cout << "You did not choose a month between 1 and 12. Try again." << endl;
			}

		} while ((n < 1) || (n > 12)); // loop when it is not between 1 and 12.



		////*****Continue through program *****///////

		// adjust input to array's starting position starting at 0
		n -= 1;

		if (DaysInMonth[n] == DaysInMonth[1]) { //DaysInMonth[1] = 'February'
			CalculateLeapYear(DaysInMonth[1]);
		}
		else {
			cout << DaysInMonth[n] << " days of the month." << endl << endl;
		}



		////***** Finishing program *****///////
		quit = QuitProgram();

		
		
	} while (toupper(quit) == 'N'); // Continue when 'N')
	cout << "Thank you for using leap year calculator." << endl;
};

/* Functions */

void CalculateLeapYear(int days) {

	int year = 0;
	// Ask for year. 
	cout << "Input the year: ";
	cin >> year;

	if (year % 4 == 0) {
		if (year % 100 != 0) {
			days++;
			cout << "The year " << year << " is not a leap year." << endl;
		}
		else if (year % 400 == 0) {
			days++;
			cout << "The year " << year << " is not a leap year." << endl;
		}
	}
	else {
		cout << "The year " << year << " is not a leap year." << endl;
	}
	cout << "There are " << days << " days of the month." << endl << endl;
}


 char QuitProgram() { 

	 char quit; // quit program variable

	do {
		// Ask to continue program or not.
		cout << "Quit Program? {'Y' or 'N'): ";
		cin >> quit;

		// Throw message for errors
		if ((quit != 'Y') && (quit != 'N')) {
			cout << "You didn't use 'Y' or 'N'. Try again. " << endl;
		}
		else if ((quit == 'Y') && (quit != 'N')) {
			break;
		}
	} while (((toupper(quit) != 'Y') && (toupper(quit) != 'N')));// Quick validation for mistaken characters - loop if not 'Y' or 'N'
	
	return quit;
}

		
