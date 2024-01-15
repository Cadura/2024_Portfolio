/*---+--------------------------+ /*
|| Project Name: Project 4
|| Author: Christopher Duran	
|| Description: Calculating the total amount 
|| of tile determined by the area of a room.
|| User-defined by their own measured inputs.
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
	double length = 0.0;
	double width = 0.0;
	double priceSqft = 0.0;
	double area = 0.0;
	double totalCost = 0.0;

	const char TAB = '\t';

	cout << "+--------------------------------------------------+" << endl;
	cout << "|     T I L E   P R I C E   C A L C U L A T O R    |" << endl  << endl;
	//input
	cout <<  "  Enter the floor length (in decimal feet): ";
	cin >> length;

	cout << "  Enter the floor width (in decimal feet): ";
	cin >> width;

	cout << "  Enter the price per square foot: ";
	cin >> priceSqft;


	//processing
	area = length * width;
	totalCost = area * priceSqft;

	//output
	cout << fixed;
	cout << setprecision(2) << endl;

	cout << TAB << "  The area of your floor is: " << area << " sq./ft. " << endl;
	cout << TAB << "+--------------------------------+" << endl;
	cout << TAB << "|                                |" << endl;
	cout << TAB << "|  The total cost is: $" << totalCost << "    |" << "  Width = " << width << " ft. " << endl;
	cout << TAB << "|                                |" << endl;
	cout << TAB << "+--------------------------------+" << endl;
	cout << TAB << TAB << "Length = " << length << " ft. " << endl;

	cout << "|--------------------------------------------------|";
	return 0;

}   //end of main function

//function declarations