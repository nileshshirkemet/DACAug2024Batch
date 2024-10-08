//class defined with primary constructor
class Interval(int min, int sec)
{
    public int Minutes { get; } = min + sec / 60;

    public int Seconds { get; } = sec % 60;

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    //overriding ToString() method of System.Object to return
    //a string representation of instance refered by this object
    public override string ToString()
    {
        if(Seconds < 10)
            return Minutes + ":0" + Seconds;
        return Minutes + ":" + Seconds;
    }

    //overriding GetHashCode() method of System.Object to return
    //an identical integer for all objects which refer to instances
    //containing matching values of fields defined by this class 
    public override int GetHashCode()
    {
        return Minutes + Seconds;
    }

    //overriding Equals() method of System.Object to return
    //true only if the instances refered by this object and 
    //other object contain matching values of fields defined
    //by this class
    public override bool Equals(object other)
    {
        if(other is Interval that)
        {
            return Minutes == that.Minutes && Seconds == that.Seconds;
        }
        return false;
    }

    //operator is overloaded using a static method, such a method
    //is called on the class instead of object1
    public static Interval operator+(Interval lhs, Interval rhs)
    {   
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }
}