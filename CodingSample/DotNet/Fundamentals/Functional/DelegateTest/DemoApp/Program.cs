using DemoApp;

double p = double.Parse(args[0]);
int n = int.Parse(args[1]);
var myinv = new Investment(p, n);
Console.WriteLine("Future value in risk-free investment: {0:0.00}", myinv.FutureValue(SafeScheme));
//passing (anonymous method) lambda-expression: (arguments) => expression
Console.WriteLine("Future value in high-risk investment: {0:0.00}", myinv.FutureValue(y => 9 + 0.25 * y));

static double SafeScheme(int y)
{
    return y < 5 ? 6 : 8;
}