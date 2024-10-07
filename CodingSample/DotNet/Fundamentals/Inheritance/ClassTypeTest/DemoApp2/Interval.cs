//class defined with primary constructor
class Interval(int min, int sec)
{
    public int Minutes { get; } = min + sec / 60;

    public int Seconds { get; } = sec % 60;

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    public override string ToString()
    {
        if(Seconds < 10)
            return Minutes + ":0" + Seconds;
        return Minutes + ":" + Seconds;
    }

    //operator is overloaded using a static method, such a method
    //is called on the class instead of object1
    public static Interval operator+(Interval lhs, Interval rhs)
    {   
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }
}