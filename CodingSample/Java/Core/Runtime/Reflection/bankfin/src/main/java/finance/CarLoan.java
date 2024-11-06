package finance;

public class CarLoan extends PersonalLoan {

    @Override
    public float common(double amount, int period) {
        return (float) (11 + amount / 500000);
    }
    
}
