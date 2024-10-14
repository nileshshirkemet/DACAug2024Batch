namespace Finance;

public static class Loans
{
	public static double GetMonthlyInstallment(double loan, int duration, double rate)
	{
		double i = rate / 1200;
		int m = 12 * duration;
		return loan * i / (1 - System.Math.Pow(1 + i, -m));
	}
}

