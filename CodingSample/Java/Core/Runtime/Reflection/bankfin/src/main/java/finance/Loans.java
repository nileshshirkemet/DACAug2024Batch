package finance;

public class Loans {
    
    public static double monthlyInstallment(double loan, int period, float rate) {
        float i = rate / 1200;
        int m = 12 * period;
        return loan * i / (1 - Math.pow(1 + i, -m));
    }
}
