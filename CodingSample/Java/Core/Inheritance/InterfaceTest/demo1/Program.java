import banking.Account;
import banking.Banker;
import banking.InsufficientFundsException;
import banking.Profitable;

class Program {

    //a method can enable 'varargs' for its last parameter (using ... operator)
    //so that it can receive an array or a sequence of argument values
    private static void payQuarterlyInterest(int count, Account... accounts) {
        for(Account acc : accounts){
            if(acc instanceof Profitable p){
                double amount = p.interest(3 * count);
                acc.deposit(amount);
            }
        }
    }

    public static void main(String[] args) {
        Account jill = Banker.openSavingsAccount();
        jill.deposit(10000);
        Account jack = Banker.openCurrentAccount();
        jack.deposit(25000);
        Account john = Banker.openSavingsAccount();
        john.deposit(30000);
        System.out.printf("Jill's Account ID is %d and Balance is %.2f%n", jill.id(), jill.balance());
        System.out.printf("Jack's Account ID is %d and Balance is %.2f%n", jack.id(), jack.balance());
        System.out.printf("John's Account ID is %d and Balance is %.2f%n", john.id(), john.balance());
        if(args.length > 0){
            System.out.printf("Jill is paying %s to Jack...%n", args[0]);
            try{
                double payment = Double.parseDouble(args[0]);
                jill.transfer(payment, jack);
                System.out.println("Payment succeeded.");
            }catch(InsufficientFundsException e){
                System.out.println("Payment failed due to lack of funds!");
            }catch(Exception e){
                System.out.printf("Error: %s%n", e.getMessage());
            }
        }else{
            System.out.println("Paying annual interest...");
            //payQuarterlyInterest(4, new Account[]{jill, jack, john});
            payQuarterlyInterest(4, jill, jack, john);
        }
        System.out.printf("Jill's New Balance: %.2f%n", jill.balance());
        System.out.printf("Jack's New Balance: %.2f%n", jack.balance());
        System.out.printf("John's New Balance: %.2f%n", john.balance());
    }
}