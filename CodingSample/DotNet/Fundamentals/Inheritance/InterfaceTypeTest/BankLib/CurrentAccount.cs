namespace Banking;

//a class defined with 'sealed' keyword cannot be extended
sealed class CurrentAccount : Account
{
    public override void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

    public override void Deposit(decimal amount)
    {
        if(Balance < 0)
            amount *= 0.9m;
        Balance += amount;
    }
}
