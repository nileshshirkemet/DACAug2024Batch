static class Activity
{
    public static int Perform(int amount)
    {
        int limit = Environment.TickCount + amount * 1000;
        while(Environment.TickCount < limit);
        return amount;
    }
}