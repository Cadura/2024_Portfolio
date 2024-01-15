#include <iostream>
#include <iomanip>

// Author: Christopher Duran
// Date: 10/19/2022
// Description: Displaying the first Sunday for Easter, 
//				based on a given year.

using namespace std;


//int Calculate_Easter_Year();
void PrintSuffix(int);

void main()

{	// declarations
	int year = 0;
	int month = 0;
	int day = 0;

	// Title Screen Load
	cout << "Welcome to the Easter Date Calculator for the Western Church (1583 to 4099)" << endl;
	cout << "---------------------------------------------------------------------------" << endl << endl;
	cout << "This program will determine the first day of Easter based on the given year." << endl << endl;
	// Continue asking "year" prompt until user enters '0' or lower
	do {
		// reset year and prompt
		 year = 0;
		 cout << "Please enter a year between 1583 to 4099 inclusive." << endl;
		 cout << "(Enter zero or a negative number to quit.): ";
		 cin >> year;
		 cout << endl;

		 // input validation: if true, continue through code

		 if (year >= 1583 && year <= 4099) {

			 //easter sunday algorithm

			 int a = year % 19;
			 int b = year / 100;
			 int c = year % 100;
			 int d = b / 4;
			 int e = b % 4;
			 int f = (b + 8) / 25;
			 int g = (b - f + 1) / 3;
			 int h = (19 * a + b - d - g + 15) % 30;
			 int i = c / 4;
			 int k = c % 4;
			 int l = (32 + 2 * e + 2 * i - h - k) % 7;
			 int m = (a + 11 * h + 22 * l) / 451;

			 month = (h + l - 7 * m + 114) / 31;
			 int p = (h + l - 7 * m + 114) % 31;
			 day = p + 1;

			 // Display 

			 string month_print = month == 3 ? "March " : "April ";
			 cout << month_print;
			 //void function prints suffix
			 PrintSuffix(day);
			 cout << year << endl << endl;


		 }
		 else if (year >= 1) {
			 cout << "You entered an invalid year." << endl;
			 cout << "-----------------------------" << endl;
		 }



	} while (year > 0);

	cout << "Good-Bye!" << endl;

}

// determines what appropiate suffix to display based on date.
void PrintSuffix(int easterDate) {

	if (easterDate == 1 || easterDate == 21)
		cout << easterDate << "st, ";
	else if (easterDate == 2 || easterDate == 22)
		cout << easterDate << "nd, " ;
	else if (easterDate == 3 || easterDate == 23)
		cout << easterDate << "rd, ";
	else 
		cout << easterDate << "th, ";

}

