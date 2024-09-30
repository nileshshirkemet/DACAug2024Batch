#include "interval2.h"
#include <cstdio>

int main(void)
{
	Interval a(2, 30);
	a.Print();
	puts("Copying...");
	Interval b = a; //Interval b(a)
	b.Print();
	Interval c(3, 45);
	c.Print();
	puts("Adding...");
	Interval d = a + b + c; //a + b ===> a.operator+(b)
	d.Print();
}

