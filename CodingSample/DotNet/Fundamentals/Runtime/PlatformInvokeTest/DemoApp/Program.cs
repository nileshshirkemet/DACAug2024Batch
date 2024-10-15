using DemoApp;

ulong l = ulong.Parse(args[0]);
ulong u = ulong.Parse(args[1]);
Console.WriteLine("Number of Primes = {0}", Primes.CountBetween(l, u)); 
if(args.Length > 2)
{
    int n = int.Parse(args[2]);
    //Span<T> provides a common abstraction for buffer of T type
    //elements on stack or on heap
    Span<ulong> primes = n <= 10 ? stackalloc ulong[n] : new ulong[n];
    Primes.FetchSelected(l, primes);
    Console.Write("Selected primes:");
    foreach(ulong prime in primes)
        Console.Write(" {0}", prime);
    Console.WriteLine();
}