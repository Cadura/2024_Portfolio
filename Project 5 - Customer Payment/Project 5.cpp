/*---+--------------------------+ /*
|| Project Name: Project 5 - Customer Payment
|| Author: Christopher Duran
|| Description:	Application calculates change from
|| the customer's total.
|| Concepts: using doubles, and setting precision through iomanip lib
||  Note: Static converting used.
||
/*---+--------------------------+ */


//includes
#include <iostream>
#include <iomanip>

using namespace std;

//function prototypes


int main() //begin main
{
	//declarations
	double customerOwe = 0.0;
	double cashGiven = 0.0;
	double remaining = 0.0;
	double pennies = 0.0;
	int dollars = 0;
	int quarters = 0;
	int dimes = 0;
	int nickels = 0;	

	//input
	cout << "Welcome to change calculator!" << endl;
	cout << "--------------------------------" << endl << endl;
	cout << "Enter the amount the customer owes: $";
	cin >> customerOwe;
	
	cout << "Enter the cash amount given: $";
	cin >> cashGiven;
	
	//processing
	if (cashGiven > customerOwe)
	{
		// Calculate Change
		 remaining = cashGiven - customerOwe + 0.000001;
		//Convert to pennies
		double change = remaining * 100;

		//Count individual change
		dollars = static_cast<int>(change) / 100;
		change -= dollars * 100;

		quarters = static_cast<int>(change) / 25;
		change -= quarters * 25; // 25 reverts quarter back to pennies to subtract

		dimes = static_cast<int>(change) / 10;
		change = change - dimes * 10;

		nickels = static_cast<int>(change) / 5;
		change -= nickels * 5;

		pennies = change;

		//output
		cout << "Change: $" << fixed << setprecision(2) << remaining << endl;
		cout << "------------" << endl;
		cout << "Dollars: " << dollars << endl;
		cout << "Quarters: " << quarters << endl;
		cout << "Dimes: " << dimes << endl;
		cout << "Nickels: " << nickels << endl;
		cout << "Pennies: " << setprecision(0) << pennies << endl;

	}
	//output
	else if (cashGiven == customerOwe) {
		cout << "No change owed." << endl;
	}
	else {
		//output
		remaining = customerOwe - cashGiven;
			cout << "You still owe: $" << remaining << endl;
	}

	return 0; 

}   //end of main function

//function declarations