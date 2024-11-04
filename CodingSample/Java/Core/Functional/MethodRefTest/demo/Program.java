class Program {

    static class SafeScheme implements InterestRate {

        public double forPeriod(int years) {
            return years < 3 ? 6 : 7;
        }
    }

    public static void main(String[] args) {
        double p = Double.parseDouble(args[0]);
        int n = Integer.parseInt(args[1]);
        Investment myinv = new Investment(p, n);
        System.out.printf("Future value of risk-free investment: %.2f%n", myinv.futureValue(new SafeScheme()));
    }
}