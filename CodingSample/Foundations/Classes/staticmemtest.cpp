#include "interval1.h"
#include <cstdio>

int main(void)
{
	Interval a(3, 20);
    Interval a1;
    a.Print();

	Interval b(1, 65);
	b.Print();

	printf("Number of intervals activated = %d\n", Interval::Activated());
}

