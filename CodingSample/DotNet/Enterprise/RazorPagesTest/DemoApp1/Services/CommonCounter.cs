namespace DemoApp.Services;

public class CommonCounter : ICounter
{
    private int current = 0;

    public int CountNext(string id)
    {
        return Interlocked.Increment(ref current);
    }
}