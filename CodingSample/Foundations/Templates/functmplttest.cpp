#include "interval.h"
#include <iostream>
#include <string>

using namespace std;

/*
double Select(int index, double first, double second)
{
	if(index % 2)
		return first;
	return second;
}

string Select(int index, string first, string second)
{
	if(index % 2)
		return first;
	return second;
}
*/

template<typename T>
T Select(int index, T first, T second) //Select is function-template with type-parameter T
{
	if(index % 2)
		return first;
	return second;
}

int main(void)
{
	int n;
	cout << "Count: ";
	cin >> n;

	//calling templated Select with T=double
	double sd = Select<double>(n, 23.4, 14.9);
	cout << "Selected double value = " << sd << endl;

	//type inference from arguments
	string ss = Select(n, "Tuesday", "Thursday"); //Select<string>(n, sa, sb)
	cout << "Selected string value = " << ss << endl;
	
	Interval si = Select(n, Interval(3, 45), Interval(3, 65));
	cout << "Selected Interval value = " << si.AsString() << endl;
}

