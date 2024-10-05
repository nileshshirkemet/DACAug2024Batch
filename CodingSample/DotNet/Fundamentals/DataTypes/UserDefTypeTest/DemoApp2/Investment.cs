using System;

enum RiskLevel {None, Low, High}

struct Investment
{
    private double payment;
    private int count;
    private RiskLevel risk;

    public Investment(double amount, int years)
    {
        payment = amount;
        count = years;
        risk = RiskLevel.None;
    }

    public void AllowRisk(bool yes)
    {
        risk = yes ? RiskLevel.Low : RiskLevel.None;
    }

    //overloading method with different list of
    //parameter types
    public void AllowRisk(RiskLevel level)
    {
        risk = level;
    }

    public double TotalPayment()
    {
        return payment * count;
    }

    public double FutureValue()
    {
        double i;
        switch(risk)
        {
            case RiskLevel.Low:
                i = 0.08;
                break;
            case RiskLevel.High:
                i = 0.12;
                break;
            default:
                i = 0.06;
                break;
        }
        return (payment / i) * (Math.Pow(1 + i, count) - 1);
    }
}