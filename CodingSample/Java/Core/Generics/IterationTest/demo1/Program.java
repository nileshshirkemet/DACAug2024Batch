class Program {

    public static void main(String[] args) {
        var a = new SimpleStack<String>();
        a.push("Monday");
        a.push("Tuesday");
        a.push("Wednesday");
        a.push("Thursday");
        a.push("Friday");
        for(var i = a.iterator(); i.hasNext();)
            System.out.println(i.next());
        System.out.println("------------------");
        while(!a.empty())
            System.out.println(a.pop());
        System.out.println("------------------");
        var b = new SimpleStack<Double>();
        b.push(47.1);
        b.push(63.2);
        b.push(58.3);
        b.push(36.4);
        for(double d : b)
            System.out.println(d);
    }
}