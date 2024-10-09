namespace Banking;

//A class defined with 'static' keyword can only define
//static members. Such a class does not support a constructor
//and therefore it cannot be instantiated or extended
public static class Banker // factory class
{
    private static long nid = DateTime.Now.Ticks % 1000000;

    public static Account OpenCurrentAccount()
    {
        //implicitly typed local - actual type of a local
        //variable declared using 'var' keyword will be 
        //infered from its initializer expression
        var acc = new CurrentAccount();
        acc.Id = ++nid + 100000000;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        var acc = new SavingsAccount();
        acc.Id = ++nid + 200000000;
        return acc;
    }

    //Extension method is a member of static class whose first parameter
    //is qualified with 'this' keyword. Such a method can be called as
    //an instance method of its first parameter type by using namespace
    //of the static class in which it is defined.
    public static void Transfer(this Account from, decimal amount, Account into)
    {
        if(ReferenceEquals(from, into))
            throw new ArgumentException("Illegal transfer");
        from.Withdraw(amount);
        into.Deposit(amount);
    }
}