namespace Sales;

public class Product
{
    public int Id { get; set; }

    public decimal Price { get; set; }

    public List<Order> Orders { get; set; }
}
