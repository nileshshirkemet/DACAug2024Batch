namespace DemoApp;

public class Shop
{
    public record Item(string Name, string Brand);

    public record Customer(string Id, decimal Purchase, int Rating);

    public static Item[] GetItems()
    {
        return new Item[]
        {
            new Item("cpu", "intel"),
            new Item("ssd", "samsung"),
            new Item("motherboard", "intel"),
            new Item("ddr", "samsung"),
            new Item("cpu", "amd"),
            new Item("keyboard", "logitech"),
            new Item("mouse", "logitech"),
            new Item("monitor", "samsung")
        };
    }

    public static ICollection<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer("Omkar", 48000, 3),
            new Customer("Sameer", 62000, 2),
            new Customer("Pranay", 95000, 5),
            new Customer("Abhay", 36000, 1),
            new Customer("Tanuja", 58000, 4),
            new Customer("Flute", 88000, 4),
            new Customer("Dhiraj", 22000, 2),
            new Customer("Kunal", 71000, 5),
            new Customer("Nishant", 135000, 5),
            new Customer("Manish", 44000, 3)
        };
    }

}