#include <cstdio>

class Interval
{
public:
	Interval(int m , int s)
	{
		id = ++count;
		min = m + s / 60;
		sec = s % 60;
		printf("Interval<%d> activated.\n", id);
	}


	int Time() const
	{
		return 60 * min + sec;
	}

	void Reset(int t)
	{
		min = t / 60;
		sec = t % 60;
	}

	//instance member function is called on object (using .)
	//and as such it receives 'this' argument which addresses
	//the instance on which it is called and therefore it
	//can refer to any other member of the class
	void Print() const
	{
		printf("Interval<%d> = %d:%02d\n", id, min, sec);
	}

	//static member function is called on class (using ::)
	//and as such it does not receive 'this' argument
	//and therefore it cannot refer to other non-static members 
	//of the class
	static int Activated()
	{
		return count;
	}

	//A destructor is a special member function which reverses
	//any side-effect of the constructor. A destructor is called
	//for a stack-based instance when its local identifier goes
	//out of scope and for any other instance when it is removed
	//from the memory
	~Interval()
	{
		printf("Interval<%d> deactivated.\n", id);
	}
private:
	int id, min, sec; //instance member variables - values stored separately in each instance
	static int count; //static member variable - value shared by all instances
};

int Interval::count = 0; //initialize static member variable in program data section

