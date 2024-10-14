namespace Finance;

public class CarLoan
{
    public double Common(double amount, int period) => amount < 500000 ? 16 : 18;

    public double Commercial(double amount, int period) => Common(amount, period) - 4;
    
}
