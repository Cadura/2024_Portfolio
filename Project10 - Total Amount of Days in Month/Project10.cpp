#include <iostream>
#include <iomanip>

// Author: Christopher Duran
// Date: 10/28/2022
// Description: Display the reward points based on membership
//				and monthly purchases.

/*
		Standard:	Points %	Plus:		Points %	Premium:  Points %
	
			n < 75		5%		n < 150		6%		n < 200			4%
		  75 - 149.99	7.5%	n > 150		13%		n > 200			15%
			n > 150		10%
*/
using namespace std;

// Function Prototypes
char QuitProgram();
void StandardMember();
void PlusMember();
void PremiumMember();
double MonthlyPurchase();




int main() {

	cout << "Welcome to the department store's rewards calculator!" << endl << endl;

	//declarations
	int m = 0; // membership input
	char quit;
	do {
		// input validation for memmberhip
		do {
			cout << "Input your membership between 1 and 3 (Standard: 1, Plus: 2, Premium: 3): ";
			cin >> m;

			/* m is a number, so if cin aka input does not take in a number,
			 then it fails. This if-statements catches that fail and resets. */

			if (!cin) // or if (cin.fail())
			{
				// user didn't input a number
				cin.clear(); // reset failbit - reset the stream
				cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); //skip bad input - delete that input. Then new line('\n')

			}
			// error message when input is not between 1 and 12.
			if ((m < 1) || (m > 3)) {
				cout << "You did not choose a membership between 1 and 3. Try again." << endl;
			}

		} while ((m < 1) || (m > 3)); // loop when it is not between 1 and 12.

		// Decision path for membership
		switch (m) {
		case 1:
			StandardMember();
			break;
		case 2:
			PlusMember();
			break;

		default:
			PremiumMember();
		}

		////***** Finishing program *****///////

		quit = QuitProgram();
	} while (quit == 'N');

	return 0;
}

char QuitProgram() {

	char quit; // quit program variable

	do {

		cout << endl << endl;
		// Ask to continue program or not.
		cout << "Quit Program? ('Y' or 'N'): ";
		cin >> quit;

		// Throw message for errors
		if ((quit != 'Y') && (quit != 'N')) {
			cout << "You didn't use 'Y' or 'N'. Try again. " << endl;
		}
	} while ((quit != 'Y') && (quit != 'N')); // Quick validation for mistaken characters - loop if not 'Y' or 'N'

	return quit;
}

void StandardMember() {
	double points = 0;
	double amount = MonthlyPurchase();
	 if (amount < 75) {
		 points = (amount * 0.05);
	 }
	 else if (amount < 150) {
		 points = (amount * 0.075);
	 }
	 else {
		 points = (amount * 0.1);
	 }
	 cout << "You have received ";
	 cout << fixed;
	 cout << setprecision(0);
	 cout << points << " rewards points this month." << endl;
	 cout << "Thank You for shopping with us!" << endl;

}
void PlusMember() {
	double points = 0;
	double amount = MonthlyPurchase();
	if (amount < 150) {
		points = (amount * 0.06);
	}
	else {
		points = (amount * 0.13);
	}
	cout << "You have received ";
	cout << fixed; 
	cout << setprecision(0);
	cout << points << " rewards points this month." << endl;
	cout << "Thank You for shopping with us!" << endl;


}
void PremiumMember() {
	double points = 0;
	double amount = MonthlyPurchase();
	if (amount < 200) {
		points = (amount * 0.04);
	}
	else {
		points = (amount * 0.15);
	}
	cout << "You have received ";
	cout << fixed;
	cout << setprecision(0);
	cout << points << " rewards points this month." << endl;
	cout << "Thank You for shopping with us!" << endl;

}

double MonthlyPurchase() {
	double amount = 0;
	do {
		cout << "Input your monthly purchase amount, including cents: ";
		cin >> amount;
		cout << endl;
		if (!cin)
		{
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		} 
		if (amount <= 0)
			cout << "You did not enter an appropiate amount. Try again." << endl;
	} while (amount <= 0);

	return amount;
	
}

