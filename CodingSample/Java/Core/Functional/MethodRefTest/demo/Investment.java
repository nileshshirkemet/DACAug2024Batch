//make static members of java.lang.Math accessible without class qualification
import static java.lang.Math.*;

class Investment {
    
    //a final instance field can only be assigned in a constructor
    private final double payment;
    private final int years;

    public Investment(double amount, int period) {
        payment = amount;
        years = period;
    }

    public double payment() {
        return payment;
    }

    public int years() {
        return years;
    }

    public double futureValue(InterestRate rate) {
        double i = rate.forPeriod(years) / 100;
        return (payment / i) * (pow(1 + i, years) - 1);
    }
}
