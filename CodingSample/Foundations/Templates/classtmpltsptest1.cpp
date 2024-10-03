#include "interval.h"
#include <iostream>
#include <string>

using namespace std;

//overloading > operator for Interval
bool operator>(const Interval& x, const Interval &y)
{
	return x.Time() > y.Time();
}

template<typename V>
class Selector //Selector class template with type-parameter V
{
public:
	Selector(V x, V y) : first(x), second(y)
	{
	}

	V Select() const
	{
		if(first > second)
			return first;
		return second;
	}
	
private:
	V first, second;
};

template<> //full specialization of Selector class template for V=string
class Selector<string>
{
public:
	Selector(const string& x, const string& y) : first(x), second(y)
	{
	}

	string Select()
	{
		if(first.size() > second.size())
			return first;
		return second;
	}
private:
	string first, second;
};

int main(void)
{
	Selector<double> a(23.4, 43.2);
	double sd = a.Select();
	cout << "Selected double value = " << sd << endl;

	//specialized Selector template will be used
	Selector<string> b("Tuesday", "Thursday");
	string ss = b.Select();
	cout << "Selected string value = " << ss << endl;

	Selector<Interval> c(Interval(3, 45), Interval(3, 65));
	Interval si = c.Select();
	cout << "Selected Interval value = " << si.AsString() << endl;
}

