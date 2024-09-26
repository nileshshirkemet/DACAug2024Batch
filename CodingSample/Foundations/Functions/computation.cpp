#include "computation.h"
#include <cmath>

double Compute(int first, int last, float level)
{
	double result = 0;

	if(first > last)
		throw first; //transfer control to code in exception handler of int type

	for(int num = first; num <= last; ++num)
	{
		result += pow(num, level);
	}

	return result; //transfer control to code after the call
}

