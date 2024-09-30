#include <cstdio>

class Interval
{
public:
	Interval(int m = 0, int s = 0)
	{
		id = ++count;
		min = m + s / 60;
		sec = s % 60;
	}

	//copy constructor
	Interval(const Interval& other)
	{
		id = ++count;
		min = other.min;
		sec = other.sec;
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

	void Print() const
	{
		printf("Interval<%d> = %d:%02d\n", id, min, sec);
	}

	Interval operator+(const Interval& rhs) const
	{
		return Interval(min + rhs.min, sec + rhs.sec);
	}

	static int Activated()
	{
		return count;
	}

private:
	int id, min, sec;
	static int count;
};

int Interval::count = 0;

