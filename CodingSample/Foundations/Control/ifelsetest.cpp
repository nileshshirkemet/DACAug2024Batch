#include <cstdio>

int main(void)
{
	float width = 0;
	float height = 0;
	float rate;
	short int count;
	
	printf("Dimensions of Banner: ");
	scanf("%f%f", &width, &height);
	printf("Number of Banners   : ");
	scanf("%hd", &count);

	if(width > height)
	{
		printf("Designing landscape banners...\n");
		rate = 0.80;
	}
	else
	{
		printf("Designing potrait banners...\n");
		rate = 0.95;
	}

	double payment = width * height * count * rate;

	printf("Total Payment = %.2lf\n", payment);
	
}

