namespace Taxation;

public struct Worker(int jobs) : ITaxPayer
{
    //Explicit implementation of an interface method
    //by qualifying method name with interface name.
    //Such a method can only be called through a 
    //reference of interface type
    decimal ITaxPayer.AnnualIncome()
    {
        return 180000 + 500 * jobs;
    }
}