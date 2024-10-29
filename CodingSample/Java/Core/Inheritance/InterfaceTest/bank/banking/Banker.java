package banking;

public class Banker {
    
    private static long nid = System.currentTimeMillis() % 1000000;

    public static Account openCurrentAccount() {
        //implicitly typed local variable: var = CurrentAcount
        var acc = new CurrentAccount(); 
        acc.id = ++nid + 100000000;
        return acc;
    }

    public static Account openSavingsAccount() {
        var acc = new SavingsAccount();
        acc.id = ++nid + 200000000;
        return acc;
    }

    //a class with only static members should define a
    //private constructor to disable unneccessary instantiation
    private Banker(){}
}
