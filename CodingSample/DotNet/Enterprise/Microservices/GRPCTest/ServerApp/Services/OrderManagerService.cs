using Grpc.Core;
using Sales;
using ServerApp.Data;

namespace ServerApp.Services;

public class OrderManagerService(ShopDbContext shop) : OrderManager.OrderManagerBase
{
    public override async Task<OrderStatus> PlaceOrder(OrderInput request, ServerCallContext context)
    {
        var reply = new OrderStatus();
        var ctr = await shop.Counters.FindAsync("order");
        var order = new Order 
        {
            Id = ++ctr.CurrentValue + ctr.SeedValue,
            OrderDate = DateOnly.FromDateTime(DateTime.Now),
            CustomerId = request.CustomerCode,
            ProductId = request.ItemCode,
            Quantity = request.ItemCount
        };
        shop.Orders.Add(order);
        try
        {
            await shop.SaveChangesAsync();
            reply.ConfirmationCode = order.Id;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            context.Status = new Status(StatusCode.Internal, "Order Failed");
        }
        return reply;
    }

    public override async Task FetchOrders(CustomerInput request, IServerStreamWriter<CustomerOrder> responseStream, ServerCallContext context)
    {
        var messages = from order in shop.Orders
                        where order.CustomerId == request.CustomerCode
                        select new CustomerOrder 
                        {
                            ItemCode = order.ProductId,
                            ItemCount = order.Quantity,
                            ConfirmationDate = order.OrderDate.ToString("yyyy-MM-dd")
                        };
        foreach(var message in messages)
            await responseStream.WriteAsync(message);
            
    }
}