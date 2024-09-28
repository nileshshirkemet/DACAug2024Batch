#include <cstdio>

double ExpenseSequence(int year)
{
	return 5 * year - 2;
}

double IncomeSequence(int year)
{
	return year * year + 1;
}

double CommonSum(int years, double (*sequence)(int))
{
	double total = 0;

	for(int year = 1; year <= years; ++year)
	{
		total += sequence(year);
	}

	return total;
}


int main(void)
{
	int count;

	printf("Number of Years: ");
	scanf("%d", &count);

	printf("Total Expense: %.2f\n", CommonSum(count, &ExpenseSequence));
	printf("Total Income : %.2f\n", CommonSum(count, &IncomeSequence));
}

