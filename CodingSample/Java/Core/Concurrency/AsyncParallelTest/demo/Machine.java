class Machine {

    public static long doWork(int amount) {
        long count = amount;
        long goal = System.currentTimeMillis() + 100 * amount;
        while(System.currentTimeMillis() < goal);
        return count * amount;
    }
}
