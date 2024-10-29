package banking;

//a class defined with 'abstract' keyword
//cannot be instantiated
public abstract class Account {
    
    long id;
    protected double balance;

    public long id() {
        return id;
    }

    public double balance() {
        return balance;
    }

    //a method defined with 'abstract' keyword
    //does mnot have a body
    public abstract void deposit(double amount);

    public abstract void withdraw(double amount) throws InsufficientFundsException;

    //a method declared with 'final' keyword 
    //cannot be overridden in the derived class
    public final void transfer(double amount, Account that) throws InsufficientFundsException {
        if(this == that)
            throw new IllegalTransferException();
        this.withdraw(amount);
        that.deposit(amount);
    }

}
