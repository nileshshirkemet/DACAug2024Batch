static class Activity
{
    public static long Perform(int amount)
    {
        int limit = Environment.TickCount + amount * 100;
        long count = amount + 1;
        while(Environment.TickCount < limit);
        return amount * count;
    }
}