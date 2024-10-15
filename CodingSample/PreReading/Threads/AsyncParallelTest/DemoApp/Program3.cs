class Program
{
    class Computation
    {
        private System.Diagnostics.Stopwatch clock = new();

        public long Compute(int begin, int count)
        {
            clock.Start();
            return Enumerable.Range(begin, count)
                    .AsParallel()
                    .Select(Activity.Perform)
                    .Sum();
        }

        public Task<long> ComputeAsync(int begin, int count)
        {   
            return Task<long>.Run(() => Compute(begin, count));
        }

        public double Time()
        {
            clock.Stop();
            return clock.Elapsed.TotalSeconds;
        }
    }

    //a method declared with 'async' keyword can return the specified
    //task using the 'await' statement
    static async Task HandleJob(int jid)
    {
        Console.Write("Computing...");
        var c = new Computation();
        //await operator will suspend execution of code that follows it
        //until the target task completes and yield a task composed of
        //the target task and the task that executes the code that follows
        //it back to the caller 
        long r = await c.ComputeAsync(1, jid);
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, c.Time());
    }

    static void Main(string[] args)
    {
        int n = int.Parse(args[0]);
        var job = HandleJob(n);
        while(!job.IsCompleted)
        {
            Console.Write('.');
            Thread.Sleep(500);
        }
    }
}