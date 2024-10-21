namespace Tourism.Data;

public class Traveler
{
    //persistent property
    public string Id { get; set; }

    //persistent property
    public int Rating { get; set; }

    //navigation (one-to-many) property
    public List<Trip> Tours { get; set; } = [];
}