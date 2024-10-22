namespace Tourism.Data;

public class Trip
{
    //persistent property
    public int Id { get; set; }

    //persistent property
    public DateTime Checkin { get; set; } = DateTime.Now;

    //navigation (many-to-one) property
    public Traveler Guest { get; set; }
}