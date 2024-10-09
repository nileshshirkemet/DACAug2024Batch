namespace Banking;

//Only a type declared with 'public' keyword
//is visible outside of the current assembly/project.
//A class declared with 'abstract' keyword
//does not support activation.
public abstract class Account
{
    public long Id { get; internal set; }

    public decimal Balance { get; protected set; }    

    //A method declared using 'abstract' keyword
    //is pure - it does not provide any specific implementation
    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
}

