#include "boards.h"
#include <iostream>

using namespace Ads;

double Order(Signboard* board, int count)
{
	float discount = count < 10 ? 0 : 0.05;
	double extra = 0;
	//dynamic_cast uses runtime-type identification(RTTI)
	//to convert one pointer type to another and if 
	//the conversion is not permitted it returns nullptr
	Wasteful* wastage = dynamic_cast<Wasteful*>(board);
	if(wastage != nullptr)
		extra = 0.75 * wastage->Scrap();
	return count * (1 - discount) * board->Price() + extra;
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

