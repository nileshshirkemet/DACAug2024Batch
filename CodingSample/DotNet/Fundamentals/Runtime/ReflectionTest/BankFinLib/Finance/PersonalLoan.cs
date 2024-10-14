namespace Finance;

public class PersonalLoan 
{
	public float Common(decimal amount, int period) => 11 + 0.5f * (period / 3);

	public float Employee(decimal amount, int period) => Common(amount, period) - 5;
}

