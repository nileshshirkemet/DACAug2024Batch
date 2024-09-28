#include "interval1.h"
#include <cstdio>

float Speed(float distance, const Interval* duration)
{
	//duration[0].Reset(0);
	return 3.6 * distance / duration->Time();
}

int main(void)
{
	Interval a(3, 20);
	a.Print();
	printf("Speed for this interval = %.2f\n", Speed(600, &a));

	Interval b(1, 65);
	b.Print();
	printf("Speed for this interval = %.2f\n", Speed(600, &b));

	printf("Number of intervals activated = %d\n", Interval::Activated());
}

