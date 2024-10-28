class Program {

    private static void advise(Investment inv) {
        inv.allowRisk(inv.totalPayment() < 500000);
    }

    public static void main(String[] args) {
        System.out.println("Welcome Investor!");
        if(args.length > 1){
            double p = Double.parseDouble(args[0]);
            int n = Integer.parseInt(args[1]);
            Investment myinv = new Investment(p, n);
            System.out.printf("Future value in risk-free investment: %.2f%n", myinv.futureValue());
            myinv.allowRisk(true);
            System.out.printf("Future value in low-risk investment : %.2f%n", myinv.futureValue());
            advise(myinv);
            System.out.printf("Future value in smart investment    : %.2f%n", myinv.futureValue());
        }
    }
}