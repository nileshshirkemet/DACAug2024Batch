namespace DemoApp;

static class Machine
{
    public static int DoWork(int amount, int balance, int op)
    {
        int goal = Environment.TickCount + amount / 100;
        while(Environment.TickCount < goal);
        return balance + op * amount;
    }
}