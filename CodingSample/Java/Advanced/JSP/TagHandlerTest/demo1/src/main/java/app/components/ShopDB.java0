package app.components;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ShopDB {
    
    public static Connection connect() throws SQLException {
        return DriverManager.getConnection("jdbc:oracle:thin:@//iitdac.met.edu/xe", "scott", "tiger");
    }
}
