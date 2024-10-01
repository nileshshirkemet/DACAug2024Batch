#include "boards.h"
#include <iostream>

using namespace Ads;

double Order(Signboard* board, int count)
{
	float discount = count < 10 ? 0 : 0.05;
	return count * (1 - discount) * board->Price();
}

int main(void)
{
	int n;
	std::cout << "Number of Signboards: ";
	std::cin >> n;

	RectangularBoard a(9.5, 4.5, Medium::Wood);
	std::cout << "Total payment for rectangular boards: "
			  << Order(&a, n)
			  << std::endl;
	CircularBoard b(7.5, Medium::Metal);
	std::cout << "Total payment for circular boards   : "
			  << Order(&b, n)
			  << std::endl;

}

