#include "banners.h"
#include <cstdio>

double Order(const Ads::Banner& poster, int quantity)
{
	float d = quantity < 10 ? 0 : 0.05;
	//when a virtual method defined by a class is called
	//on its pointer/reference, it is invoked using
	//dynamic-binding in which the address of the method
	//implementation is discovered from the pointed/referenced
	//instance
	return quantity * (1 - d) * poster.Price();
}

int main(void)
{
	using namespace Ads;

	float w, h;
	printf("Dimensions of Banner: ");
	scanf("%f%f", &w, &h);
	int n;
	printf("Number of Banners: ");
	scanf("%d", &n);

	Banner a(w, h);
	HardBanner b(w, h, 3);
	printf("Total payment for regular banner: %.2lf\n", Order(a, n));
	printf("Total payment for hard banner   : %.2lf\n", Order(b, n));
}

