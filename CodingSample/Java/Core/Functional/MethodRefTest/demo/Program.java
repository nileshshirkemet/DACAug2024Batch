class Program {

    private static double safeScheme(int years) {
        return years < 3 ? 6 : 7;
    }

    public static void main(String[] args) {
        double p = Double.parseDouble(args[0]);
        int n = Integer.parseInt(args[1]);
        Investment myinv = new Investment(p, n);
        System.out.printf("Future value of risk-free investment: %.2f%n", myinv.futureValue(Program::safeScheme));
        //passing lambda-expression - an anonymous method (implemented at compile-time)
        //compatible with functional interface
        System.out.printf("Future value of riskful investment  : %.2f%n", myinv.futureValue(y -> 8 + 0.25 * y));
    }
}