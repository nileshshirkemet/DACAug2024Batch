class Machine {

    public static int doWork(int amount, int balance, int op) {
        long goal = System.currentTimeMillis() + amount / 100;
        while(System.currentTimeMillis() < goal);
        return balance + op * amount;
    }
}
