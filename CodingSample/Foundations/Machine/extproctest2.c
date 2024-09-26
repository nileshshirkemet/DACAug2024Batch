#include "console.h"

extern long gcd(long, long);

int main(void)
{	
	long m = GetInt("First Integer : ");
	long n = GetInt("Second Integer: ");

	PutInt("L.C.M = ", m * n / gcd(m, n));
}

