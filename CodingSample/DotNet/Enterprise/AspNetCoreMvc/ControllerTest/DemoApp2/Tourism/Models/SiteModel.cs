using Tourism.Data;

namespace Tourism.Models;

public class SiteModel
{
    public IEnumerable<Visitor> GetVisitors()
    {
        using var site = new SiteDbContext();
        var selection = from t in site.Travelers
                        where t.Id.Length > 3
                        select new Visitor 
                        {
                            Name = t.Id,
                            Visits = t.Tours.Count,
                            Recent = t.Tours.Max(e => e.Checkin),
                            Stars = new string('*', t.Rating)
                        };
        return selection.ToList();
    }

    public void AcceptVisit(string visitorId, int visitorRating)
    {
        using var site = new SiteDbContext();
        var traveler = site.Travelers.Find(visitorId);
        if(traveler is null)
        {
            traveler = new Traveler { Id = visitorId };
            site.Travelers.Add(traveler);
        }
        traveler.Tours.Add(new Trip());
        traveler.Rating = visitorRating;
        site.SaveChanges();
    }
}