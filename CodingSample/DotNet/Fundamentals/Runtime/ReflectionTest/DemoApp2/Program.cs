using System.Reflection;
using Finance;
using RateFunc = System.Func<decimal, int, float>;

decimal p = decimal.Parse(args[0]);
Type t = Type.GetType($"Finance.{args[1]},BankFinLib", true);
object policy = Activator.CreateInstance(t); //dynamic activation
var scheme = t.GetMethod(args[2]);
var rf = scheme.CreateDelegate<RateFunc>(policy);
var md = scheme.GetCustomAttribute<MaxDurationAttribute>();
int m = md?.Limit ?? 10;
for(int n = 1; n <= m; ++n)
{
    float r = rf(p, n);
    decimal emi = Loans.GetMonthlyInstallment(p, n, r);
    Console.WriteLine("{0, -8}{1, 20:0.00}", n, emi);
}

