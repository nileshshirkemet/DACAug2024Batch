package app.components;

import java.sql.Connection;
import java.sql.SQLException;

import com.zaxxer.hikari.HikariConfig;
import com.zaxxer.hikari.HikariDataSource;

public class ShopDB {
    
    private static HikariDataSource poolManager = new HikariDataSource(
        new HikariConfig("datasource.properties"));

    public static Connection connect() throws SQLException {
        return poolManager.getConnection();
    }
}
