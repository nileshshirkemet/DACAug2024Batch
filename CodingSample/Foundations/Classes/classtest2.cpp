#include "banner2.h"
#include <cstdio>

int main()
{
	Banner b;
	printf("Price of standard banner: %.2f\n", b.Price());

	float w, h;
	printf("Banner Dimensions: ");
	scanf("%f%f", &w, &h);

	Banner c;
	c.Resize(w, h);
	printf("Price of custom rectangular banner: %.2f\n", c.Price());
	c.Reshape(Geometry::Elliptical);
	printf("Price of custom elliptical banner : %.2f\n", c.Price());

}

