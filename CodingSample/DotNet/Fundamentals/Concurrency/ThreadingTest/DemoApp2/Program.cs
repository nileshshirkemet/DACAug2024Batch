namespace DemoApp;

class Program
{
    class JointAccount
    {
        public int Balance { get; private set; }

        public bool Debit(int amount)
        {
            bool success = false;
            //Caller thread must acquire ownership of the monitor 
            //associated with the instance referred by 'this' in order 
            //to continue, if this monitor is owned by another thread 
            //the caller must wait until the current owner releases
            //the ownership.
            Monitor.Enter(this);
            try
            {
                if(Balance >= amount)
                {
                    Balance = Machine.DoWork(amount, Balance, -1);
                    success = true;
                }
            }
            finally
            {
                //release ownership of the monitor associated with the
                //instance referred by 'this' object
                Monitor.Exit(this); 
            }
            return success;
        }

        public void Credit(int amount)
        {
            lock(this)
            {
                Balance = Machine.DoWork(amount, Balance, 1);
                //wakeup any thread that is waiting on the
                //monitor of this object
                Monitor.Pulse(this);
            }
        }

        public bool DebitAfterCredit(int amount)
        {
            lock(this)
            {
                //release the ownership of the monitor of this object,
                //wait for this monitor to be pulsed and then resume
                //after reaquring the monitor
                Monitor.Wait(this);
                return Debit(amount);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Opening joint account for Jack and Jill...");
        var acc = new JointAccount();
        acc.Credit(10000);
        Console.WriteLine("Initial Balance: {0}", acc.Balance);
        var first = new Thread(() => 
        {
            Console.WriteLine("Jack is withdrawing 7000...");
            if(!acc.Debit(7000))
                Console.WriteLine("Jack's transaction failed!");
        });
        first.Start();
        var second = new Thread(() =>
        {
            Console.WriteLine("Jill is withdrawing 8000...");
            if(!acc.Debit(8000))
                Console.WriteLine("Jill's transaction failed!");  
        });
        second.Start();
        first.Join(); //caller (main thread) waits for first thread to exit
        second.Join();
        Console.WriteLine("Final Balance  : {0}", acc.Balance);
    }
}
