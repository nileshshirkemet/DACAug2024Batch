class Program
{
    static string user;

    static void HandleJob(int jid)
    {
        Console.WriteLine("Thread<{0}> has accepted job {1} for {2}", Thread.CurrentThread.ManagedThreadId, jid, user);
        Activity.Perform(jid);
        Console.WriteLine("Thread<{0}> has finished job {1} for {2}", Thread.CurrentThread.ManagedThreadId, jid, user);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 1;
        user = "Jack";
        HandleJob(n);
        user = "Jill";
        HandleJob(2);
    }
}
