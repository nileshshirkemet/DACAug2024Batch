static class Activity
{
    public static int Perform(int balance, int amount)
    {
        int limit = Environment.TickCount + amount / 100;
        while(Environment.TickCount < limit);
        return balance - amount;
    }
}