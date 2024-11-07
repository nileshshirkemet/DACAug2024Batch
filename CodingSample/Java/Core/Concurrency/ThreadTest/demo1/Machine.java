class Machine {

    public static void doWork(int amount) {
        long goal = System.currentTimeMillis() + 1000 * amount;
        while(System.currentTimeMillis() < goal);
    }
}
