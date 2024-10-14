namespace DemoApp;

delegate double InterestRate(int years);

class Investment(double payment, int count)
{
    public double FutureValue(InterestRate scheme)
    {
        double i = scheme(count) / 100;
        return (payment / i) * (Math.Pow(1 + i, count) - 1);
    }
}