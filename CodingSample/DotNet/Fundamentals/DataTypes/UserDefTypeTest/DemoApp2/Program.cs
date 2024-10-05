using System;

class Program
{
	//a parameter declared with 'ref' keyword expects the location
	//of the argument instead of a copy of its value
	static void Advise(ref Investment inv)
	{
		inv.AllowRisk(inv.TotalPayment() < 500000);
	}

	static void Main(string[] args)
	{
		Console.WriteLine("Welcome Investor!");
		if(args.Length > 1)
		{
			double p = double.Parse(args[0]);
			int n = int.Parse(args[1]);
			Investment myinv = new Investment(p, n);
			Console.WriteLine("Future value of risk-free investment: {0:0.00}", myinv.FutureValue());
			myinv.AllowRisk(true);
			Console.WriteLine("Future value of riskful investment  : {0:0.00}", myinv.FutureValue());
			Advise(ref myinv); //passing location of myinv instance
			Console.WriteLine("Future value of smart investment    : {0:0.00}", myinv.FutureValue());
			myinv.AllowRisk(RiskLevel.High);
			Console.WriteLine("Future value of high-risk investment: {0:0.00}", myinv.FutureValue());
		}
	}
}

