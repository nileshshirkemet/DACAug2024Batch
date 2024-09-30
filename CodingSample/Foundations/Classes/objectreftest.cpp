#include "interval1.h"
#include <cstdio>

//A C++ reference type (T&) represents an address (like T*)
//but with support for automatic initialization (without &)
//and automatic indirection (without [0]). Unlike pointer type,
//reference type cannot be defined without initializer and it
//does not support multiple-indirection (like T**). A reference
//type identifier declared with 'const' qualifier treats the
//addressed value as read-only.
float Speed(float distance, const Interval& duration)
{
	return 3.6 * distance / duration.Time();
}

int main(void)
{
	Interval a(3, 20);
	a.Print();
	printf("Speed for this interval = %.2f\n", Speed(600, a));

	Interval b(1, 65);
	b.Print();
	printf("Speed for this interval = %.2f\n", Speed(600, b));

	printf("Number of intervals activated = %d\n", Interval::Activated());
}

