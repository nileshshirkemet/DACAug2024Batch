#include "interval.h"
#include <iostream>
#include <string>

using namespace std;

template<typename T>
T Select(T first, T second) //Select is function-template with type-parameter T
{
	if(first > second)
		return first;
	return second;
}

//explicit specialization of Select template for T=Interval
template<> 
Interval Select(Interval first, Interval second) 
{
	if(first.Time() > second.Time())
		return first;
	return second;
}

int main(void)
{
	double sd = Select<double>(23.4, 34.9);
	cout << "Selected double value = " << sd << endl;

	string ss = Select("Tuesday", "Thursday");
	cout << "Selected string value = " << ss << endl;

	//specialized Select will be called
	Interval si = Select(Interval(3, 45), Interval(3, 65));
	cout << "Selected Interval value = " << si.AsString() << endl;
}

