/*---+--------------------------+ /*
|| Project Name: Project 6
|| Author: Christopher Duran
|| Description: Calculating prices for pizzas.
||  Adding decision paths for amount of medium and large pizzas.
||
/*---+--------------------------+ */


//includes
#include <iostream>
#include <iomanip>

using namespace std;



int main() //begin main
{
	//declarations
	const double mediumPrice = 9.99;
	const double largePrice = 12.99;
	const double discount = 0.1;
	const int coupon = 2;

	int mediumPizzas = 0;
	int largePizzas = 0;
	int pizzaCount;
	char answer;
	
	double totalPrice = 0.0; // variable after discounts
	double initialPrice = 0.0; // variable before discounts
	//input
	cout << "Please enter the number of medium pizza: "; // Input medium pizzas
	cin >> mediumPizzas;

	if (mediumPizzas < 0) // Check for errors. Under 0 inputs
		cout << "No pizza slices of any size or molecule! Enter a proper number! Thank You!" << endl;
	else {
		cout << "Please enter the number of large pizzas: "; // Input large pizzas
		cin >> largePizzas;
		if (largePizzas < 0)
			cout << "No pizza slices of any size or molecule! Enter a proper number! Thank You!" << endl;
		else if (mediumPizzas == 0 && largePizzas == 0) { // Special message for no orders
			cout << "No orders entered! End of Program!" << endl;
		}
		//processing
		else {
			pizzaCount = mediumPizzas + largePizzas;
			// getting initial price
			initialPrice = mediumPizzas * mediumPrice;
			initialPrice += (largePizzas * largePrice);

			// check discounts
			if (pizzaCount >= 4) {
				initialPrice -= (initialPrice * discount);
			}

			// check large pizza coupon
			if (largePizzas >= 1) {
				initialPrice -= coupon;
			}

			//output
			cout << "Total amount of pizzas: " << pizzaCount << endl;
			cout << "Total cost of pizza: " << fixed << setprecision(2) << initialPrice << endl;

		}
	}

	return 0;

}   //end of main function
