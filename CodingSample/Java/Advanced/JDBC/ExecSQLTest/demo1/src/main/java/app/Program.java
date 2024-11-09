package app;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Program {
    
    public static void main(String[] args) throws Exception {
        Connection con = DriverManager.getConnection("jdbc:mysql://dac-faculty.local/sales", "root", "root");
        Statement stmt = con.createStatement();
        if(args.length == 0){
            ResultSet rs = stmt.executeQuery("select pno, price, stock from products");
            while(rs.next())
                System.out.printf("%-6d%12.2f%8d%n", rs.getInt(1), rs.getDouble(2), rs.getInt("stock"));
            rs.close();
        }else{
            int id = Integer.parseInt(args[0]);
            int n = stmt.executeUpdate("update products set stock=stock+5 where pno=" + id);
            if(n == 0)
                System.out.println("No such product!");
        }
        stmt.close();
        con.close();
    }

}

