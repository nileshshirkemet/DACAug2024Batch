namespace DemoApp;

static class Machine
{
    public static long DoWork(int amount)
    {
        long seed = amount;
        int goal = Environment.TickCount + amount * 100;
        while(Environment.TickCount < goal);
        return seed * amount;
    }
}