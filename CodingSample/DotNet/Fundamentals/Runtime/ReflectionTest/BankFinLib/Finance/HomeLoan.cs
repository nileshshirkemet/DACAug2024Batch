namespace Finance;

public class HomeLoan
{
	public float Common(decimal amount, int period) => amount < 5000000 ? 9 : 8.5f;

	public float Woman(decimal amount, int period) => Common(amount, period) - 1;
	
	[MaxDuration(Limit = 12)]
	public float Welfare(decimal amount, int period) => 0.5f * Common(amount, period);
}

