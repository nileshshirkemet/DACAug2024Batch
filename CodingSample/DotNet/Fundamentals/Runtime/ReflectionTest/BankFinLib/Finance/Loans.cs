namespace Finance;

public static class Loans
{
	public static decimal GetMonthlyInstallment(decimal loan, int duration, float rate)
	{
		double i = rate / 1200;
		int m = 12 * duration;
		double g = i / (1 - Math.Pow(1 + i, -m));
		return (decimal)g * loan;
	}
}

