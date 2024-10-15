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

        //Task<T> represents an awaitable (asyncronously runnable)
        //operation with a result of type T
        public Task<long> ComputeAsync(int begin, int count)
        {   
            //the operation passed to Task<T>.Run is invoked by one of the worker threads
            //(managed by the CLR) allowing the calling thread to resume execution 
            //and obtain the result of invocation from the returned task once it 
            //is completed by that worker
            return Task<long>.Run(() => Compute(begin, count));
        }

        public double Time()
        {
            clock.Stop();
            return clock.Elapsed.TotalSeconds;
        }
    }

    static Task HandleJob(int jid)
    {
        Console.Write("Computing...");
        var c = new Computation();
        return c.ComputeAsync(1, jid)
                .ContinueWith(previous => 
                {
                    long r = previous.Result;
                    Console.WriteLine("Done!");
                    Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, c.Time());                    
                });

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