#include <cstdio>

double ExpenseSequence(int year)
{
	return 5 * year - 2;
}

double IncomeSequence(int year)
{
	return year * year + 1;
}

double ExpenseSum(int years)
{
	double total = 0;

	for(int year = 1; year <= years; ++year)
	{
		total += ExpenseSequence(year);
	}

	return total;
}

double IncomeSum(int years)
{
	double total = 0;

	for(int year = 1; year <= years; ++year)
	{
		total += IncomeSequence(year);
	}

	return total;
}

int main(void)
{
	int count;

	printf("Number of Years: ");
	scanf("%d", &count);

	printf("Total Expense: %.2f\n", ExpenseSum(count));
	printf("Total Income : %.2f\n", IncomeSum(count));
}

