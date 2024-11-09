package app.models;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class ShopModel {
    
    private String server;

    public ShopModel(String server) {
        this.server = server;
    }

    public ItemInfo readItemInfo(String name) throws IOException {
        //Step 1
        Socket connection = new Socket(server, 4000);
        try{
            //Step 2
            var receiver = connection.getInputStream();
            var reader = new BufferedReader(new InputStreamReader(receiver));
            var sender = connection.getOutputStream();
            var writer = new PrintWriter(sender, true);
            reader.readLine(); //read greeting message
            writer.println(name);
            String message = reader.readLine();
            writer.close();
            reader.close();
            if(message != null)
                return ItemInfo.parse(message);
            return new ItemInfo(0, 0);
        }finally{
            //Step 3
            connection.close();
        }
    }
    
}
