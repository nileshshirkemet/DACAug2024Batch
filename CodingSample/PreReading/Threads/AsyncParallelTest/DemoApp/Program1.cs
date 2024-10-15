class Program
{
    class Computation
    {
        private System.Diagnostics.Stopwatch clock = new();

        public long Compute(int begin, int count)
        {
            clock.Start();
            return Enumerable.Range(begin, count)
                    .Select(Activity.Perform)
                    .Sum();
        }

        public double Time()
        {
            clock.Stop();
            return clock.Elapsed.TotalSeconds;
        }
    }

    static void HandleJob(int jid)
    {
        Console.Write("Computing...");
        var c = new Computation();
        long r = c.Compute(1, jid);
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, c.Time());
    }

    static void Main(string[] args)
    {
        int n = int.Parse(args[0]);
        HandleJob(n);
    }
}