using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome Investor!");
		if(args.Length > 1)
		{
			double p = double.Parse(args[0]);
			int n = int.Parse(args[1]);
			Console.WriteLine("Future value of risk-free investment: {0:0.00}", Investment.FutureValue(p, n, false));
			Console.WriteLine("Future value of riskful investment  : {0:0.00}", Investment.FutureValue(p, n, true));
		}
	}
}

