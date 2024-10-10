namespace Taxation;

public struct Supervisor(int subordinates) : ITaxPayer
{
    decimal ITaxPayer.AnnualIncome()
    {
        return 480000 + 5000 * subordinates;
    }
}