#include "interval1.h"
#include <cstdio>

int main(void)
{
	int n;
	printf("Number of Intervals: ");
	scanf("%d", &n);

	if(n <= 1)
	{
		//activate an instance of Interval by allocating required
		//memory on the runtime heap using 'new' operator
		Interval* a = new Interval(3, 45);
		a->Print();
		//an instance activated on runtime heap must be
		//explicitly deactivated using 'delete' operator
		delete a;
	}
	else
	{
		//activating an array of 'n' Intervals instances on runtime 
		//heap (using default constructor) using new[] operator which
		//returns address of first instance;
		Interval* b = new Interval[n];
		for(int i = 0; i < n; ++i)
		{
			b[i].Reset(225 + 40 * i);
			b[i].Print();
		}
		//deactivating all instances in an array on runtime heap
		//using delete[] operator
		delete[] b;
	}
	puts("Goodbye.");
}

