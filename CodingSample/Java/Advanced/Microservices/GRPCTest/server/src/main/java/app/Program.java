package app;

import app.shopping.services.OrderManagerService;
import io.grpc.ServerBuilder;

public class Program {
    
    public static void main(String[] args) throws Exception {
        System.out.println("Starting server on http://localhost:4030...");
        ServerBuilder.forPort(4030)
            .addService(new OrderManagerService())
            .build()
            .start()
            .awaitTermination();

    }
}

