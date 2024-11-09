package app;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

import app.models.ShopModel;

public class Program {
    
    static final ShopModel model = ShopModel.build();

    public static void main(String[] args) throws Exception {
        //Step 1
        try(var listener = new ServerSocket(4000)){
            System.out.println("Shop server started on TCP port 4000.");
            while(true){
                //Step 2
                var client = listener.accept();
                //Step 3 and 4
                communicate(client);
            }
        }
    }

    private static void communicate(Socket connection) {
        try{
            try{
                //Step 3
                var receiver = connection.getInputStream();
                var reader = new BufferedReader(new InputStreamReader(receiver));
                var sender = connection.getOutputStream();
                var writer = new PrintWriter(sender, true);
                writer.println("Welcome to EviTek computers.");
                String item = reader.readLine();
                String info = model.getItemInfo(item);
                if(info != null)
                    writer.println(info);
                writer.close();
                reader.close();
            }finally{
                //Step 4
                connection.close();
            }
        }catch(Exception e){
            System.out.printf("Communication failure: %s%n", e);
        }
    }

}

