using System;

class Investment
{
    public static double FutureValue(double payment, int count, bool risk)
    {
        double i = risk ? 0.08 : 0.06;
        return (payment / i) * (Math.Pow(1 + i, count) - 1);
    }

}