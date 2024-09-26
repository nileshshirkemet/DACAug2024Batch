#include <cstdio>

int main(void)
{
	long lower, upper;

	printf("Lower and Upper Limits: ");
	scanf("%ld%ld", &lower, &upper);

	long result = 0;
	for(auto current = lower; current <= upper; ++current)
	{
		result += current * current;
	}

	printf("Result of Computation = %ld\n", result);
}

