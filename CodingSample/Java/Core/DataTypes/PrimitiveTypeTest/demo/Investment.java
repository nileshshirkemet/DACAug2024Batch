class Investment {
    
    public static double futureValue(double payment, int count, boolean risk) {
        double i = risk ? 0.08 : 0.06;
        return (payment / i) * (Math.pow(1 + i, count) - 1);
    }
}
