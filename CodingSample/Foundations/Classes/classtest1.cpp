#include "banner1.h"
#include <cstdio>

int main()
{
	Banner b; //activating instance of Banner class using default constructor
	printf("Price of standard banner: %.2f\n", b.Price());

	float w, h;
	printf("Banner Dimensions: ");
	scanf("%f%f", &w, &h);

	Banner c;
	c.Resize(w, h); //Banner::Resize(&c, w, h)
	printf("Price of custom banner: %.2f\n", c.Price());
}

