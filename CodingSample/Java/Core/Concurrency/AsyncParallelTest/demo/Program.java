import java.util.stream.IntStream;

class Program {

    static class Computation {

        private long start;

        public long compute(int first, int last) {
            start = System.currentTimeMillis();
            return IntStream.range(first, last + 1)
                .mapToLong(Machine::doWork)
                .sum();
        }

        public double time() {
            long current = System.currentTimeMillis();
            return (current - start) / 1000.0;
        }
    }

    public static void main(String[] args) throws Exception {
        int n = Integer.parseInt(args[0]);
        System.out.print("Computing...");
        var c = new Computation();
        long r = c.compute(1, n);
        System.out.println("Done!");
        System.out.printf("Result = %d, computed in %.3f seconds.%n", r, c.time());
    }
}
