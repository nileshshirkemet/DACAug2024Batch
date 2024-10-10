namespace Taxation;

public interface ITaxPayer
{
    decimal AnnualIncome();

    //A method defined in an interface with a default implementation
    //can on only be called through a reference of that interface type
    decimal IncomeTax()
    {
        decimal i = AnnualIncome();
        return i > 200000 ? 0.15m * (i - 200000) : 0;
    }
}