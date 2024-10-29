package banking;

//an exception class which inherits from java.lang.Exception but not
//from java.lang.RuntimeException is checked at compile time meaning
//it can only occur in a try block that catches this exception type
//or a method in which it is declared to be thrown
public class InsufficientFundsException extends Exception {
    
}
