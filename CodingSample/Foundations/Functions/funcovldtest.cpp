#include <cstdio>

double BannerPrice(float width, float height) //_Z11BannerPriceff
{
	float rate = width > height ? 0.80 : 0.95;
	return width * height * rate;
}

//function overloading - defining a function whose name matches
//with another function in the current scope but with a different
//list of parameter types
double BannerPrice(float width, float height, short thickness) //_Z11BannerPriceffs
{
	float rate = 1.15;
	return width * height * thickness * rate; 
}

int main(void)
{
	float w, h;
	int n;

	printf("Dimensions of Banner: ");
	scanf("%f%f", &w, &h);
	printf("Number of Banners   : ");
	scanf("%d", &n);

	printf("Total payment for regular banners: %.2lf\n", n * BannerPrice(w, h));
	printf("Total payment for layered banners: %.2lf\n", n * BannerPrice(w, h, 3));
}


