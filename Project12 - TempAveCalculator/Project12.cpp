#include <iostream>
#include <iomanip>
using namespace std;

/* 
	Concept: Using 2d arrays and navigating data through them.
*/

void QuitProgram(bool &quitflag);

bool quitflag = false;

int main() {

	// Declarations
	// 2D Array 7 day rows, 2 temperature range columns
						// Highest Lowest
	
	/* Example: int temperatures[7][2]{{95, 67}, //Day 1
							{98, 54}, // 2
							{86, 70}, // 3
							{99, 56}, // 4
							{83, 34}, // 5
							{75, 68}, // 6
							{80, 45}  }; // 7 */
	cout << "Welcome to average temperature calculator!" << endl;
	cout << "------------------------------------------" << endl;
	cout << "Instructions: Enter 7 days of the highest temperature and the lowest temperature." << endl; 
	cout << "The average temperatures will be calculated for you." << endl << endl; 
	do {
		quitflag = false;
		int intHighAverage = 0;
		int intLowAverage = 0;
		int temperature[7][2];
		int temp = 0;

		for (int r = 0; r < 7; r++) { // row - row will have to indicate position in outer array
			for (int c = 0; c < 2; c++) {	// column - column will have to indicate position in inner array
				if (c == 0) {

					cout << "Enter highest temperatures from Day " << r + 1 << ": ";
					cin >> temp;
					temperature[r][c] = temp;
					intHighAverage += temp;
				}
				else {
					cout << "Enter lowest temperatures from Day " << r + 1 << ": ";
					cin >> temp;
					temperature[r][c] = temp;
					intLowAverage += temp;

				}
			}
		}
		intHighAverage = intHighAverage / 7;
		intLowAverage = intLowAverage / 7;
		cout << "The average highest temperature for that week is: ";
		cout << fixed << setprecision(1) << intHighAverage << " degrees" << endl;
		cout << "The average highest temperature for that week is: ";
		cout << fixed << setprecision(1) << intLowAverage << " degrees" << endl;


		// Quitting the program
		QuitProgram(quitflag);


	} while (quitflag);
	system("pause");
	return 0;
}

// Void function using 'by reference' on the quitflag boolean 
void QuitProgram(bool &quitflag) {
		char quit;
		do {
			cout << "Do you want to continue? Y or N? ";
			cin >> quit;
			if (toupper(quit) == 'Y') {
				quitflag = true;
				system("cls");
			}
			else if (toupper(quit) == 'N')
				quitflag = false;
			else
				cout << "You did not enter a 'Y' or a 'N'. Try again!" << endl;
		} while (toupper(quit) != 'Y' && toupper(quit) != 'N');
}