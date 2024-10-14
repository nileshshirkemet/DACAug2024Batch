namespace DemoApp;

record Item(string Name, string Brand);

readonly record struct Customer(string Id, decimal Purchase, int Rating);

class Shop
{
    public static Item FavoriteItem()
    {
        return new Item("cpu", "intel");
    }

    public static Customer FavoriteCustomer()
    {
        return new Customer("Jack", 86000, 5);
    }
}