using System.ComponentModel.DataAnnotations;

namespace Tourism.Data;

public class Traveler
{
    [StringLength(32, MinimumLength = 4)]
    public string Id { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }

    public List<Trip> Tours { get; set; } = [];
}