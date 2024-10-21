using Tourism.Models;

var model = new SiteModel();
if(args.Length > 0)
{
    model.AcceptVisit(args[0], 5);
    Console.WriteLine("Welcome {0}!", args[0]);
}
else
{
    foreach(var visitor in model.GetVisitors())
        Console.WriteLine("{0}\t{1}\t{2}", visitor.Name, visitor.Visits, visitor.Recent);
}
