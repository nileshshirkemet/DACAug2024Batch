#include <cstdio>

double Average(double first, double second, double* deviation)
{
	//deviation[0] = first > second ? (first - second) / 2 : (second - first) / 2;
	*deviation = first > second ? (first - second) / 2 : (second - first) / 2;
	return (first + second) / 2;
}

int main(void)
{
	double x, y;

	printf("Two Values: ");
	scanf("%lf%lf", &x, &y);

	double d;
	double a = Average(x, y, &d);
	printf("Average = %lf with Deviation = %lf\n", a, d);
}

