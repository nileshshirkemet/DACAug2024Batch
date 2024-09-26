#include <cstdio>

int main(void)
{
	int age;
	
	printf("Age: ");
	scanf("%d", &age);

	float rate;
	switch(age)
	{
		case 16:
			rate = 75;
			break;
		case 18:
			rate = 125;
			break;
		case 21:
			rate = 150;
			break;
		case 50:
			rate = 200;
			break;
		default:
			rate = 50;
	}

	printf("Gift Amount: %.2f\n", age * rate);
}

