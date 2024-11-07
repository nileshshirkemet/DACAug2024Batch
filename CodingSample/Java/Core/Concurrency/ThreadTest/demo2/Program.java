class Program {

    static class JointAccount {

        private int balance;

        public int balance() {
            return balance;
        }

        public boolean debit(int amount) {
            boolean success = false;
            //to enter a syncronized statement block a thread must acquire
            //ownership of the monitor of the target object(this), if this
            //monitor is owned by some other thread, this thread must wait
            //until its current owner releases the monitor by exiting the
            //synchronized statement block
            synchronized(this){
                if(this.balance >= amount){
                    this.balance = Machine.doWork(amount, this.balance, -1);
                    success = true;
                }
            }
            return success;
        }

        public synchronized void credit(int amount) {
            balance = Machine.doWork(amount, balance, +1);
            this.notify();
        }

        public synchronized boolean debitAfterCredit(int amount) throws InterruptedException {
            //release ownership of this object's monitor, wait
            //for this monitor to be notified and then reaquire
            //ownership of the monitor and resume
            this.wait();
            return debit(amount);
        }
    }

    public static void main(String[] args) throws Exception {
        var acc = new JointAccount();
        acc.credit(10000);
        System.out.println("Joint account opened for Jack and Jill.");
        System.out.printf("Initial Balance: %d%n", acc.balance());
        var first = Thread.ofPlatform().start(() -> {
            System.out.println("Jack is withdrawing 6000 from account...");
            if(!acc.debit(6000))
                System.out.println("Jack's transaction failed!");
        });
        var second = Thread.ofPlatform().start(() -> {
            System.out.println("Jill is withdrawing 7000 from account...");
            if(!acc.debit(7000))
                System.out.println("Jill's transaction failed!");
        });
        first.join(); //current(main) thread waits for first thread to exit
        second.join();
        System.out.printf("Final Balance: %d%n", acc.balance());
    }
}
