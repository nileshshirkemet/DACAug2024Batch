class Program {

    public static void main(String[] args) {
        long l = Long.parseUnsignedLong(args[0]);
        long h = Long.parseUnsignedLong(args[1]);
        System.out.printf("Number of Primes: %d%n", Primes.countBetween(l, h));
        if(args.length > 2){
            int n = Integer.parseInt(args[2]);
            long[] primes = Primes.fetchSelected(l, n);
            System.out.println("Selected Primes");
            for(long p : primes)
                System.out.println(p);
        }
    }
}