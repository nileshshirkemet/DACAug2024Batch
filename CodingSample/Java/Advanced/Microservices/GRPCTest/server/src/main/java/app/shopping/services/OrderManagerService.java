package app.shopping.services;

import java.util.Date;

import app.shopping.data.CounterEntity;
import app.shopping.data.OrderEntity;
import io.grpc.Status;
import io.grpc.stub.StreamObserver;
import jakarta.persistence.EntityManagerFactory;
import jakarta.persistence.Persistence;
import sales.OrderManagerGrpc.OrderManagerImplBase;
import sales.OrderManagerOuterClass.CustomerInput;
import sales.OrderManagerOuterClass.CustomerOrder;
import sales.OrderManagerOuterClass.OrderInput;
import sales.OrderManagerOuterClass.OrderStatus;

public class OrderManagerService extends OrderManagerImplBase {

    private static EntityManagerFactory emf = Persistence.createEntityManagerFactory("app.data");

    @Override
    public void fetchOrders(CustomerInput request, StreamObserver<CustomerOrder> responseObserver) {
        try(var em = emf.createEntityManager()){
            em.createQuery("SELECT e FROM OrderEntity e WHERE e.customerId=:customer", OrderEntity.class)
                .setParameter("customer", request.getCustomerCode())
                .getResultList()
                .forEach(entity -> {
                    var message = CustomerOrder.newBuilder()
                            .setItemCode(entity.getProductNo())
                            .setItemCount(entity.getQuantity())
                            .setConfirmationDate(entity.orderDateAsString())
                            .build();
                    responseObserver.onNext(message);
                });
                responseObserver.onCompleted();
        }
    }

    @Override
    public void placeOrder(OrderInput request, StreamObserver<OrderStatus> responseObserver) {
        try(var em = emf.createEntityManager()){
            var tx = em.getTransaction();
            tx.begin();
            int orderNo = em.find(CounterEntity.class, "orders")
                .generateNextId(1000);
            var entity = new OrderEntity();
            entity.setOrderNo(orderNo);
            entity.setOrderDate(new Date());
            entity.setCustomerId(request.getCustomerCode());
            entity.setProductNo(request.getItemCode());
            entity.setQuantity(request.getItemCount());
            em.persist(entity);
            tx.commit();
            var reply = OrderStatus.newBuilder()
                .setConfirmationCode(orderNo)
                .build();
            responseObserver.onNext(reply);
            responseObserver.onCompleted();
        }catch(Exception e){
            e.printStackTrace();
            var fault = Status.INTERNAL.withDescription("Order Failed").asRuntimeException();
            responseObserver.onError(fault);
        }
    }
    
}
