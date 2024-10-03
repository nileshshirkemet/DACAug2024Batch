#include <iostream>
#include <string>

using namespace std;

template<typename I, typename V>
class IndexedValue
{
public:
	IndexedValue(I i, V v) : index(i), value(v){}

	void Print() const
	{
		cout << "(" << index << ") ---> " << value << endl;
	}
private:
	I index;
	V value;
};

template<typename I> //partial specialization of IndexedValue class template
class IndexedValue<I, bool>
{
public:
	IndexedValue(I i, bool v) : index(i), value(v){}

	void Print() const
	{
		cout << "(" << index << ") ---> " << (value ? "yes" : "no") << endl;
	}
private:
	I index;
	bool value;
};

template<typename V>
class IndexedValue<int, V>
{
public:
	IndexedValue(V v) : value(v)
	{
		static int count = 0;
		index = ++count;
	}

	void Print() const
	{
		cout << "[" << index << "] ---> " << value << endl;
	}
private:
	int index;
	V value;
};

int main(void)
{
	IndexedValue<string, double> a("Monday", 23.4);
	a.Print();

	IndexedValue<string, bool> b("Retired", true);
	b.Print();

	IndexedValue<int, string> c("January");
	c.Print();

	IndexedValue<int, string> d("February");
	d.Print();
}

