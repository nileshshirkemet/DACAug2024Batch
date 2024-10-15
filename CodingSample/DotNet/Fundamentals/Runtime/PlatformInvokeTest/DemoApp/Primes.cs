using System.Runtime.InteropServices;

namespace DemoApp;

//As pointer-type is non-verifiable at runtime, it can only appear
//in a statement block marked with 'unsafe' keyword which is only
//available within a project that allows unsafe blocks (see DemoApp.csproj).
unsafe partial class Primes
{
    //generate platform invocation code at compile time
    [LibraryImport("primes", EntryPoint = "primes_count")]
    public static partial int CountBetween(ulong first, ulong second);

    struct PrimesRange
    {
        public ulong Start;
        public int Count;
    }

    [LibraryImport("primes", EntryPoint = "primes_fetch")]
    private static partial ulong FetchSelected(PrimesRange* range, ulong* store, delegate*<ulong, int> select);

    public static void FetchSelected(ulong first, Span<ulong> collect)
    {
        var range = new PrimesRange { Start = first, Count = collect.Length };
        //in order to take an address of a value within a block on
        //managed heap, this block must be pinned using fixed statement
        //to stop garbage collector from moving it 
        fixed(ulong* store = &collect[0])
        {
            FetchSelected(&range, store, &IsFavorite);
        }
    }

    private static int IsFavorite(ulong prime) => (prime - 1) % 4 == 0 ? 1 : 0;
}