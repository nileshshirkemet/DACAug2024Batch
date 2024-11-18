package app.components;

import java.io.IOException;
import java.sql.SQLException;

import jakarta.servlet.jsp.JspException;
import jakarta.servlet.jsp.tagext.SimpleTagSupport;

public class InvoiceModelTag extends SimpleTagSupport {
    
    private String customerId;

    private String orderVar;

    public void setCustomerId(String customerId) {
        this.customerId = customerId;
    }

    public void setOrderVar(String orderVar) {
        this.orderVar = orderVar;
    }

    @Override
    public void doTag() throws JspException, IOException {
        var context = super.getJspContext();
        var body = super.getJspBody();
        try(var con = ShopDB.connect()){
            var stmt = con.prepareStatement("select pno, qty, ord_date from orders where cust_id=?");
            stmt.setString(1, customerId);
            var rs = stmt.executeQuery();
            while(rs.next()){
                var orderVal = new OrderEntry(rs);
                context.setAttribute(orderVar, orderVal);
                body.invoke(null);
            }
            rs.close();
            stmt.close();
        }catch(SQLException e){
            throw new RuntimeException(e);
        }
    }

    
}
