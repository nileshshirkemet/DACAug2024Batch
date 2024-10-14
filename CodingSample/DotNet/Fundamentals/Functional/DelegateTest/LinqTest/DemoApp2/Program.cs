using System.Linq.Expressions;
using System.Xml.Linq;
using DemoApp;

var selection = XElement.Load("EviSoft.xml")
    .Elements("Consultant")
    .AsQueryable()
    .Select(e => new Developer
    {
        Name = e.Attribute("Id").Value,
        Degree = e.Element("Education").Value,
        Location = e.Element("Country").Value,
        Language = (string)e.Element("Skill")
    });
if(args.Length > 1)
{
    var source = Expression.Parameter(typeof(Developer));
    var match = Expression.Equal
    (
        Expression.Property(source, args[0]),
        Expression.Constant(args[1])
    );
    var filter = Expression.Lambda<Func<Developer, bool>>(match, source);
    selection = selection.Where(filter);
}
foreach(var entry in selection.OrderBy(e => e.Name))
{
    Console.WriteLine($"{entry.Name} has a {entry.Degree} degree from {entry.Location} and is a {entry.Language} developer.");
}
