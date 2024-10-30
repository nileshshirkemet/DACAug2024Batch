class Program {

    //generic method with type-parameter T
    private static <T> T select(int index, T first, T second) {
        if((index % 2) == 1)
            return first;
        return second;
    }

    private static <T extends Comparable<T>> T select(T first,  T second) {
        if(first.compareTo(second) > 0)
            return first;
        return second;
    }

    public static void main(String[] args) {
        if(args.length > 0){
            int s = Integer.parseInt(args[0]);
            String ss = select(s, "Monday", "Tuesday");
            System.out.printf("Selected String value = %s%n", ss);
            double sd = select(s, 58.7, 49.2);
            System.out.printf("Selected double value = %s%n", sd);
            //String sr = select(s, "April", 4.5);
            //System.out.printf("Selected rotten value = %s%n", sr);
        }else{
            String ss = select("Monday", "Tuesday");
            System.out.printf("Selected String value = %s%n", ss);
            double sd = select(58.7, 49.2);
            System.out.printf("Selected double value = %s%n", sd);           
            Interval si = select(new Interval(3, 45), new Interval(4, 30));
            System.out.printf("Selected Interval value = %s%n", si);
        }
    }
}