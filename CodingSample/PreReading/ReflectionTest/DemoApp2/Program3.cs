using System.Reflection;
using Finance;

double p = double.Parse(args[0]);
Type t = Type.GetType($"Finance.{args[1]},FinLib", true);
object policy = Activator.CreateInstance(t);
MethodInfo scheme = t.GetMethod(args[2]); //t.GetMethod(args[2], [typeof(double), typeof(int)])
RateFunc rf = scheme.CreateDelegate<RateFunc>(policy);
int m = 10;
for(int n = 1; n <= m; ++n)
{
    //double r = (double)scheme.Invoke(policy, [p, n]);
    double r = rf(p, n);
    double emi = Loans.GetMonthlyInstallment(p, n, r);
    Console.WriteLine("{0, -6}{1, 16:0.00}", n, emi);
}

delegate double RateFunc(double amount, int period);