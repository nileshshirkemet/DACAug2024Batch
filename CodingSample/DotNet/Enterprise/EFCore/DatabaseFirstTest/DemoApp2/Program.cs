using Microsoft.EntityFrameworkCore;
using Sales;
using Shopping.Data;

var db = new DbContextOptionsBuilder<ShopDbContext>()
    .UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False");
using var shop = new ShopDbContext(db.Options);
if(args.Length == 0)
{
    foreach(var product in shop.Products)
        Console.WriteLine("{0, -6}{1, 10:0.00}", product.Id, product.Price);
}
else
{
    int pno = int.Parse(args[0]);
    var product = shop.Products.Find(pno);
    if(product != null)
    {
        //explicit loading of child entities
        shop.Entry(product).Collection(p => p.Orders).Load(); 
        Console.WriteLine("Total Sales: {0:0.00}", product.GetTotalSales());
    }
}