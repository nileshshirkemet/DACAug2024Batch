import banking.Account;
import banking.Banker;
import banking.InsufficientFundsException;

class Program {

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
        }
        System.out.printf("Jill's New Balance: %.2f%n", jill.balance());
        System.out.printf("Jack's New Balance: %.2f%n", jack.balance());
        System.out.printf("John's New Balance: %.2f%n", john.balance());
    }
}