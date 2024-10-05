using System;

//Investment is a user-defined value type
struct Investment
{
    //instance fields
    private double payment;
    private int count;
    private bool risk;

    //constructor
    public Investment(double amount, int years)
    {
        payment = amount;
        count = years;
        risk = false;
    }

    //instance methods
    public void AllowRisk(bool yes)
    {
        risk = yes;
    }

    public double TotalPayment()
    {
        return payment * count;
    }

    public double FutureValue()
    {
        double i = risk ? 0.08 : 0.06;
        return (payment / i) * (Math.Pow(1 + i, count) - 1);
    }
}