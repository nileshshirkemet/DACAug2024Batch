import java.util.Arrays;
import java.util.Collection;

class Program {

    public static void main(String[] args) {
        if(args[0].equals("items")){
            Item[] items = Shop.getItems();
            Arrays.stream(items)
                .filter(i -> i.brand().equals(args[1]))
                .map(i -> i.name())
                .forEach(System.out::println);
        }else if(args[0].equals("customers")){
            double min = Double.parseDouble(args[1]);
            Collection<Customer> customers = Shop.getCustomers();
            customers.stream()
                .filter(c -> c.purchase() >= min)
                .sorted((x, y) -> y.rating() - x.rating())
                .map(c -> String.format("%-16s%8s",
                    c.id().toUpperCase(),
                    "*".repeat(c.rating())
                ))
                .forEach(System.out::println);
        }
    }
}