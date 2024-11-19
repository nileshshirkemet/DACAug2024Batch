package app.services;

import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;
import sales.OrderManagerGrpc;
import sales.OrderManagerGrpc.OrderManagerBlockingStub;

public class OrderManagerClient implements AutoCloseable {

    private final ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 4030)
        .usePlaintext()
        .build();

    public OrderManagerBlockingStub stub() {
        return OrderManagerGrpc.newBlockingStub(channel);
    }

    public void close() {
        channel.shutdown();
    }
}
