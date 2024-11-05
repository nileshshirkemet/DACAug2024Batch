import java.util.ArrayList;
import java.util.Collection;

record Item(String name, String brand) {}

record Customer(String id, double purchase, int rating) implements Comparable<Customer> {

    public int compareTo(Customer that) {
        return id.compareTo(that.id);
    }
}

class Shop {

    public static Item[] getItems()
    {
        return new Item[]{
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

    public static Collection<Customer> getCustomers()
    {
        var customers = new ArrayList<Customer>();
        customers.add(new Customer("Omkar", 48000, 3));
        customers.add(new Customer("Sameer", 62000, 2));
        customers.add(new Customer("Pranay", 95000, 5));
        customers.add(new Customer("Abhay", 36000, 1));
        customers.add(new Customer("Tanuja", 58000, 4));
        customers.add(new Customer("Flute", 88000, 4));
        customers.add(new Customer("Dhiraj", 22000, 2));
        customers.add(new Customer("Kunal", 71000, 5));
        customers.add(new Customer("Nishant", 135000, 5));
        customers.add(new Customer("Manish", 44000, 3));
        return customers;
    }



}
