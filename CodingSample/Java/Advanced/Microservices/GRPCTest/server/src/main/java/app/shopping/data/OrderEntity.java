package app.shopping.data;

import java.util.Date;

import jakarta.persistence.Basic;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name = "orders")
public class OrderEntity {
    
    @Id
    @Column(name = "ord_no")
    private int orderNo;

    @Basic //default
    @Column(name = "ord_date")
    private Date orderDate;

    @Column(name = "cust_id")
    private String customerId;

    @Column(name = "pno")
    private int productNo;

    @Column(name = "qty")
    private int quantity;

    public int getOrderNo() {
        return orderNo;
    }

    public void setOrderNo(int orderNo) {
        this.orderNo = orderNo;
    }

    public Date getOrderDate() {
        return orderDate;
    }

    public void setOrderDate(Date orderDate) {
        this.orderDate = orderDate;
    }

    public String getCustomerId() {
        return customerId;
    }

    public void setCustomerId(String customerId) {
        this.customerId = customerId;
    }

    public int getProductNo() {
        return productNo;
    }

    public void setProductNo(int productNo) {
        this.productNo = productNo;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public final String orderDateAsString(){
        return String.format("%tF", orderDate);
    }
}
