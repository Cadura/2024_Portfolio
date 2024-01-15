/*---+--------------------------+ /*
|| Project Name: Project 7 - Fibonacci's Number
|| Author: Christopher Duran
|| Description: Using basic fibonacci's number sequence.
|| Concept: Learning difference between
|| building with a while loop vs. for loop
||
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
	int inputFibCount;
	int numberOne = 1;
	int numberTwo = 1;
	int fibonacci;

	// index for loop
	int i = 2;

	//input

	do {
		cout << "Please input how many fibs in your set: (integer between 2 and 15): ";
		cin >> inputFibCount;
		cout << endl << endl;
	} while ((inputFibCount < 2) || (inputFibCount > 15));

	//processing

	// Display first two input numbers


	if (inputFibCount == 2) {
		cout << "Fibonacci's Numbers with no loop: (";
		cout << numberOne << ", ";
		cout << numberTwo << ", ";

	}
	else {
		cout << "Fibonacci's Numbers using a while loop: (";
		cout << numberOne << ", ";
		cout << numberTwo << ", ";

		// While loop : START
		// Goal is to display only ten numbers, including input numbers = 8
		while (i < inputFibCount) {


			fibonacci = numberOne + numberTwo;

			// Display 3rd and rest of numbers.
			cout << fibonacci;

			i == inputFibCount - 1 ? cout << " " : cout << ", ";


			// Prep for next number
			numberOne = numberTwo;
			numberTwo = fibonacci;

			// Increment
			i++;
		}

		//Output 
		cout << ")" << endl << endl;

		// for loop 

		// reset
		numberOne = 1;
		numberTwo = 1;


		cout << "Fibonacci's Numbers using a for loop: (";
		cout << numberOne << ", ";
		cout << numberTwo << ", ";


		for (i = 2; i < inputFibCount; i++) {
			fibonacci = numberOne + numberTwo;

			// Display 3rd and rest of numbers.
			cout << fibonacci;

			i < inputFibCount - 1 ? cout << ", " : cout << " ";


			// Prep for next number
			numberOne = numberTwo;
			numberTwo = fibonacci;
		}


		cout << ")" << endl << endl;

	}
	return 0;
}

   //end of main function

//function declarations