namespace Finance;

public class HomeLoan
{
	public double Common(double amount, int period) => amount < 5000000 ? 9 : 8.5;

	public double Woman(double amount, int period) => Common(amount, period) - 1;
	
	public double Welfare(double amount, int period) => 0.5 * Common(amount, period);
}

