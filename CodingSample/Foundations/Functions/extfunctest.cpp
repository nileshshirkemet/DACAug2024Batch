#include <cstdio>

extern "C" long gcd(long, long);

int main(void)
{
	long m, n;

	printf("Two positive integers: ");
	scanf("%ld%ld", &m, &n);

	printf("G.C.D = %ld\n", gcd(m, n));
}

