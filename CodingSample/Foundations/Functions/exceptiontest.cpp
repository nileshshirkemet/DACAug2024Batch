#include "computation.h"
#include <cstdio>

int main(void)
{
	int lower, upper;

	puts("Hello User.");

	printf("Lower and Upper Limits: ");
	scanf("%d%d", &lower, &upper);

	try
	{
		printf("Result of simple computation : %lf\n", Compute(lower, upper));
		printf("Result of complex computation: %lf\n", Compute(lower, upper, 3));
	}
	catch(int err)
	{
		printf("Invalid limit: %d\n", err);
	}
	puts("Goodbye User.");
}

