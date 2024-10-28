class Program {

    private static void print(String label, Object info) {
        System.out.printf("%s = %s%n", label, info);
    }

    public static void main(String[] args) {
        Interval a = new Interval(6, 20);
        Interval b = new Interval(4, 45);
        print("Interval a", a);
        print("Interval b", b);
        //print("Sum", a.add(b));
        Interval c = new Interval(5, 80);
        Interval d = b;
        print("Interval c", c);
        print("Interval d", d);
        System.out.println("----------------------------");
        System.out.printf("a is identical to b: %b%n", a == b);
        System.out.printf("a is identical to c: %b%n", a == c);
        System.out.printf("d is identical to b: %b%n", d == b);
        System.out.println("----------------------------");
        System.out.printf("a is equal to b: %b%n", a.hashCode() == b.hashCode() && a.equals(b));
        System.out.printf("a is equal to c: %b%n", a.hashCode() == c.hashCode() && a.equals(c));
        System.out.printf("d is equal to b: %b%n", d.hashCode() == b.hashCode() && d.equals(b));
        System.out.println("----------------------------");
        double e = 2.718;
        //auto-boxing: implicit conversion of a primitive type
        //to an object of its wrapper class
        print("double e", e); //print("double f", Double.valueOf(f));
    }
}