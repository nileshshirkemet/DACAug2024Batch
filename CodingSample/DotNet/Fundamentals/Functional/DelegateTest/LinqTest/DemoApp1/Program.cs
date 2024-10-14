using DemoApp;

if (args[0] == "items")
{
    var selection = Shop.GetItems()
        .Where(i => i.Brand == args[1])
        .Select(i => i.Name);

    foreach(var entry in selection)
        Console.WriteLine(entry);
}
else if(args[0] == "customers")
{
    decimal min = decimal.Parse(args[1]);
    var selection = from c in Shop.GetCustomers()
                    where c.Purchase >= min
                    orderby c.Id descending
                    select new //instantiating anonymous type with specified properties
                    {
                        Email = $"{c.Id.ToLower()}@met.edu",
                        Stars = new string('*', c.Rating)
                    };
    foreach(var entry in selection)
        Console.WriteLine("{0, -20}{1, 8}", entry.Email, entry.Stars);
}