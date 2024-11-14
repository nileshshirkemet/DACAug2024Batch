package app.components;

import java.sql.SQLException;

public class LoginModelBean {
    
    private String id;

    public String getId() {
        return id;
    }

    public boolean authenticate(String customerId, String password) {
        try(var con = ShopDB.connect()){
            var stmt = con.prepareStatement("select count(cust_id) from customers where cust_id=? and pwd=?");
            stmt.setString(1, customerId);
            stmt.setString(2, password);
            var rs = stmt.executeQuery();
            rs.next();
            int count = rs.getInt(1);
            rs.close();
            stmt.close();
            if(count == 1){
                id = customerId;
                return true;
            }
            id = null;
            return false;

        }catch(SQLException e){
            throw new RuntimeException(e);
        }
    }
}
