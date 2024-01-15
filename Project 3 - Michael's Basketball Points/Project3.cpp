/*---+--------------------------+ /*
|| Project Name: Project 3
|| Author: Christopher Duran
|| Description: Calculating basketball points Michael contributed in a basketball game.
|| Very Simple concepts: declarations, inputs/outputs, and processing.
|| Practice for unfamiliar syntax
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
	int team2Pt = 0;
	int team3Pt = 0;
	int teamFreeThrow = 0;

	// Michael's points
	int michael2Pt = 0;
	int michael3Pt = 0;
	int michaelFreeThrow = 0;

	// Team's score
	int teamScore = 0;
	int michaelScore = 0;

	// Points Michael contributes
	double michaelContrib = 0.0;
	//input

	// Text on screen
	cout << "Please enter the team's 2-point baskets: ";
	cin >> team2Pt;

	cout << "Please enter the team's 3-point baskets: ";
	cin >> team3Pt;

	cout << "Please enter the team's free throw baskets: ";
	cin >> teamFreeThrow;


	// New Blank Line
	cout << endl;

	cout << "Please enter Michael's 2-point baskets: ";
	cin >> michael2Pt;

	cout << "Please enter Michael's 3-point baskets: ";
	cin >> michael3Pt;

	cout << "Please enter Michael's free throw baskets: ";
	cin >> michaelFreeThrow;

	// Round-out the input numbers
	cout << fixed << setprecision(1);


	//processing
	teamScore = (team2Pt * 2) + (team3Pt * 3) + teamFreeThrow;
	michaelScore = (michael2Pt * 2) + (michael3Pt * 3) + michaelFreeThrow;

	michaelContrib = ((double)michaelScore / (double)teamScore) * 100.0;


	//output
	cout << endl;
	cout << "The team made a total of  " << teamScore << "  points." << endl;
	cout << "Michael made a total of   " << michaelScore << "  for the team." << endl << endl;
	cout << "Michael contributed  " << michaelContrib << "%" << "  to the team." << endl;



	return 0;

}   //end of main function

//function declarations