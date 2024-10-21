using Microsoft.EntityFrameworkCore;
using Shopping.Data;

using var shop = new ShopDbContext();
if(args.Length == 0)
{
    foreach(var customer in shop.Customers)
        Console.WriteLine("{0, -8}{1, 16:0.00}", customer.Id, customer.Credit);
}
else
{
    var customer = shop.Customers
        .Where(c => c.Id == args[0])
        .Include(c => c.Orders) //eager loading of child entities
        .FirstOrDefault();
    if(customer != null)
    {
        foreach(var entry in customer.Orders)
            Console.WriteLine("{0, -6}{1, 8}{2, 12:yyyy-MMM-dd}", entry.ProductId, entry.Quantity, entry.OrderDate);
    }
}