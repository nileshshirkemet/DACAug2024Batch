namespace Finance;

[AttributeUsage(AttributeTargets.Method)]
public class MaxDurationAttribute(int value = 5) : Attribute
{
    public int Limit { get; set; } = value;
}