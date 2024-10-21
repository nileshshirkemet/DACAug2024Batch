namespace Sales;

public static class ProductManager
{
    public static decimal GetTotalSales(this Product item)
    {
        return item.Orders
            .Select(order => order.Quantity * item.Price)
            .Sum();
    }
}