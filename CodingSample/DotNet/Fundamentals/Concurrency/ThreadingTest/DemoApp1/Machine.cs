namespace DemoApp;

static class Machine
{
    public static void DoWork(int amount)
    {
        int goal = Environment.TickCount + amount * 1000;
        while(Environment.TickCount < goal);
    }
}