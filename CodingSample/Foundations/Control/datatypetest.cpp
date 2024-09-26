#include <cstdio>

int main(void)
{
	float width = 0;
	float height = 0;
	const float rate = 0.80;
	short int count;
	
	printf("Dimensions of Banner: ");
	scanf("%f%f", &width, &height);
	printf("Number of Banners   : ");
	scanf("%hd", &count);

	double payment = width * height * count * rate;

	printf("Total Payment = %.2lf\n", payment);
	
}

