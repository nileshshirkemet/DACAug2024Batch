#include <cstdio>

int main(void)
{
	long int num;

	printf("Positive Integer: ");
	scanf("%ld", &num);

	if(num < 0)
		num = -num;
	
	long int a = 1;
	long int c = 0;
	do
	{
		a = a * 10;
		c = c + 1;
	}
	while(a <= num);

	printf("Number of Digits = %ld\n", c);

}

