class Investment {

    //instance fields
    private double payment;
    private int count;
    private boolean risk;

    //constructor
    public Investment(double amount, int years) {
        payment = amount;
        count = years;
        risk = false;
    }

    //instance method (receives 'this' argument)
    public void allowRisk(boolean yes) {
        risk = yes;
    }

    public double totalPayment() {
        return count * payment;
    }

    public double futureValue() {
        double i = risk ? 0.08 : 0.06;
        return (payment / i) * (Math.pow(1 + i, count) - 1);
    }

}
