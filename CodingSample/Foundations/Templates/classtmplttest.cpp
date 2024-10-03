#include "interval.h"
#include <iostream>
#include <string>

using namespace std;

template<typename V>
class Selector //Selector class template with type-parameter V
{
public:
	Selector(V x, V y) : first(x), second(y)
	{
	}

	V Select(int index) const
	{
		if(index % 2)
			return first;
		return second;
	}
	
private:
	V first, second;
};

int main(void)
{
	int n;
	cout << "Count: ";
	cin >> n;

	//activating templated Selector class with V=double
	Selector<double> a(23.4, 43.2);
	double sd = a.Select(n);
	cout << "Selected double value = " << sd << endl;

	Selector<string> b("Tuesday", "Thursday");
	string ss = b.Select(n);
	cout << "Selected string value = " << ss << endl;

	Selector<Interval> c(Interval(3, 45), Interval(3, 65));
	Interval si = c.Select(n);
	cout << "Selected Interval value = " << si.AsString() << endl;
}

