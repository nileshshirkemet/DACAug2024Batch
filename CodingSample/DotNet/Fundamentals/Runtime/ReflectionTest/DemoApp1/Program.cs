using System.Reflection;
using Finance;

decimal p = decimal.Parse(args[0]);
Type t = Type.GetType($"Finance.{args[1]},BankFinLib", true);
object policy = Activator.CreateInstance(t); //dynamic activation
MethodInfo scheme = t.GetMethod(args[2]);
int m = 10;
for(int n = 1; n <= m; ++n)
{
    float r = (float)scheme.Invoke(policy, [p, n]); //late binding
    decimal emi = Loans.GetMonthlyInstallment(p, n, r);
    Console.WriteLine("{0, -8}{1, 20:0.00}", n, emi);
}

