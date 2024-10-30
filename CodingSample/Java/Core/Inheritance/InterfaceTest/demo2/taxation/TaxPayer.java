package taxation;

public interface TaxPayer {
    
    float RATE = 0.15f;

    double annualIncome();

    default double incomeTax() {
        double i = annualIncome();
        return i > 200000 ? (i - 200000) * RATE : 0;
    }
}
