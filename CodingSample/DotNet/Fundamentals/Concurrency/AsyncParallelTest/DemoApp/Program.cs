using System.Diagnostics;

namespace DemoApp;

class Program
{

    class Computation
    {
        private Stopwatch clock = new();

        public long Compute(int first, int count)
        {
            clock.Start();
            return Enumerable.Range(first, count)
                .AsParallel() //split incoming sequence into multiple 
                              //subsequences each executing as a separate task
                .Select(Machine.DoWork)
                .Sum();
        }

        //Task<T> represents a schedulable unit of work that 
        //produces result of type T on completion
        public Task<long> ComputeAsync(int first, int count)
        {
            //schedule the specified operation on a worker thread
            //allowing the caller thread to resume and obtain the 
            //result after the worker has completed the operation
            return Task<long>.Run(() => Compute(first, count));
        }

        public double Time()
        {
            clock.Stop();
            return clock.Elapsed.TotalSeconds;
        }
    }

    //a method declared with 'async' keyword returns
    //the task yielded by await operator
    static async Task HandleJob(int jid)
    {
        Console.Write("Computing...");
        var c = new Computation();
        //await operator immediately yields (to the caller) a task 
        //that includes the target task and task that continues
        //execution of the subsequent code
        var r = await c.ComputeAsync(1, jid);
        Console.WriteLine("Done.");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, c.Time());
    }

    static void Main(string[] args)
    {
       int n = int.Parse(args[0]);
       var job = HandleJob(n);
       while(!job.IsCompleted)
       {
            Console.Write('.');
            Thread.Sleep(500); //pause current thread execution for 500 milliseconds.
       }
    }
}
