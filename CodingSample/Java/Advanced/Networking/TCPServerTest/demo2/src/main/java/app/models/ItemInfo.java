package app.models;

public record ItemInfo(String id, double cost, int stock) {
    
    @Override
    public String toString() {
        return String.format("cost=%s&stock=%s", cost, stock);
    }
}
