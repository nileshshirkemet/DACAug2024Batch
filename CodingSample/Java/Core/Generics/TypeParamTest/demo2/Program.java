class Program {

    private static void printStack(SimpleStack<?> stack) {
        while(!stack.empty())
            System.out.println(stack.pop());
    }

    public static void main(String[] args) {
        SimpleStack<String> a = new SimpleStack<String>();
        a.push("Monday");
        a.push("Tuesday");
        a.push("Wednesday");
        a.push("Tursday");        
        a.push("Friday");
        printStack(a);
        System.out.println("------------------");
        SimpleStack<Interval> b = new SimpleStack<>();//type inference
        b.push(new Interval(4, 31));
        b.push(new Interval(7, 42));
        b.push(new Interval(6, 13));
        b.push(new Interval(5, 54));
        printStack(b);
    }
}