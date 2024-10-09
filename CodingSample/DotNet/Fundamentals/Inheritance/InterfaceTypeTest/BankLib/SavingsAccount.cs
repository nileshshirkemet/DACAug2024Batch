namespace Banking;

sealed class SavingsAccount : Account, IProfitable
{
    //an identifier declared with 'const' keyword is replaced
    //with the value assigned to it whereever it occurs in code 
    const decimal MinBal = 5000;

    internal SavingsAccount()
    {
        Balance = MinBal;
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if(Balance - amount < MinBal)
            throw new InsufficientFundsException();
        Balance -= amount;
    }

    public void AddInterest(int months)
    {
        decimal rate = Balance < 5 * MinBal ? 3 : 4;
        decimal interest = Balance * rate * months / 1200;
        Balance += interest;
    }
}