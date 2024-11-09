package app.models;

public record ItemInfo(double cost, int stock) {
    
    public static ItemInfo parse(String message) {
        String[] parts = message.split("&");
        double c = Double.parseDouble(parts[0].substring(5));
        int s = Integer.parseInt(parts[1].substring(6));
        return new ItemInfo(c, s);
    }
}
