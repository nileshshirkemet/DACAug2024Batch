import taxation.Supervisor;
import taxation.TaxPayer;
import taxation.Worker;

class Program {

    //nested (static) member class 
    static class Auditor implements AutoCloseable {

        public Auditor() {
            System.out.println("Auditor - acquiring required resources...");
        }

        public void audit(String id, TaxPayer person) {
            if(id.length() < 4)
                throw new IllegalArgumentException("Invalid ID.");
            double payment = person.incomeTax() + 500;
            System.out.printf("Total Tax Payment: %.2f%n", payment);
        }

        public void close() {
            System.out.println("Auditor - releasing acquired resources...");
        }
    }

    private static void doAuditing(String name, int count) {
        System.out.printf("Auditing %s...%n", name);
        TaxPayer t = name.equals("jack") ? new Supervisor(count) : new Worker(count);
        try(Auditor a = new Auditor()){
            a.audit(name, t);
        } //a.close() will be automatically called in auto-generated finally block
    }

    public static void main(String[] args) {
        try{
            String m = args[0].toLowerCase();
            int n = Integer.parseInt(args[1]);
            doAuditing(m, n);
        }catch(Exception e){
            System.out.printf("Auditing failed: %s%n", e.getMessage());
        }
    }
}