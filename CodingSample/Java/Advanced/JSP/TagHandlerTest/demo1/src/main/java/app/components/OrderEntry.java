package app.components;

import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;

public class OrderEntry {
    
    private int productNo;

    private int quantity;

    private Date orderDate;

    public OrderEntry(ResultSet rs) throws SQLException {
        productNo = rs.getInt("pno");
        quantity = rs.getInt("qty");
        orderDate = rs.getDate("ord_date");
    }

    public int getProductNo() {
        return productNo;
    }

    public int getQuantity() {
        return quantity;
    }

    public Date getOrderDate() {
        return orderDate;
    }

    
}
