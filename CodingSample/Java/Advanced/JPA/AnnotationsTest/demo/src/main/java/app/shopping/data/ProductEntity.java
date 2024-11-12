package app.shopping.data;

import java.util.List;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.NamedQuery;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "products")
@NamedQuery(name = "findBigProducts", query = "SELECT p FROM ProductEntity p WHERE p.stock >= ?1")
public class ProductEntity {
    
    @Id
    @Column(name = "pno")
    private int productNo;

    @Column
    private double price;

    @Column
    private int stock;

    @OneToMany
    @JoinColumn(name = "pno")
    private List<OrderEntity> orders;
    
    public int getProductNo() {
        return productNo;
    }

    public void setProductNo(int productNo) {
        this.productNo = productNo;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public List<OrderEntity> getOrders() {
        return orders;
    }

    public void setOrders(List<OrderEntity> orders) {
        this.orders = orders;
    }
}
