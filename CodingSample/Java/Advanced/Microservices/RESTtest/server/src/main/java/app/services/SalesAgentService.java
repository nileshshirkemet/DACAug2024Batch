package app.services;

import java.util.ArrayList;

import io.grpc.StatusRuntimeException;
import jakarta.ws.rs.Consumes;
import jakarta.ws.rs.GET;
import jakarta.ws.rs.POST;
import jakarta.ws.rs.Path;
import jakarta.ws.rs.PathParam;
import jakarta.ws.rs.Produces;
import jakarta.ws.rs.core.MediaType;
import jakarta.ws.rs.core.Response;
import sales.OrderManagerOuterClass.CustomerInput;
import sales.OrderManagerOuterClass.OrderInput;

@Path("/api/sales")
public class SalesAgentService {
    
    @GET
    @Path("/{id}")
    @Produces(MediaType.APPLICATION_JSON)
    public Response readOrders(@PathParam("id") String customerId) {
        try(var remote = new OrderManagerClient()){
            var orders = new ArrayList<OrderResource>();
            var request = CustomerInput.newBuilder()
                .setCustomerCode(customerId)
                .build();
            var reply = remote.stub().fetchOrders(request);
            reply.forEachRemaining(message -> {
                var resource = new OrderResource();
                resource.productNo = message.getItemCode();
                resource.quantity = message.getItemCount();
                resource.orderDate = message.getConfirmationDate();
                orders.add(resource);
            });
            return orders.size() > 0 
                ? Response.ok(orders).build()
                : Response.status(404).build();
        }
    }

    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public Response createOrder(OrderResource resource) {
        try(var remote = new OrderManagerClient()){
            var request = OrderInput.newBuilder()
                .setCustomerCode(resource.customerId)
                .setItemCode(resource.productNo)
                .setItemCount(resource.quantity)
                .build();
            var reply = remote.stub().placeOrder(request);
            resource.orderNo = reply.getConfirmationCode();
            return Response.ok(resource).build();
        }catch(StatusRuntimeException e){
            return Response.status(500, e.getStatus().getDescription()).build();
        }
    }
}
