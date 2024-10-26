namespace DemoApp.Resources;

using Grpc.Core;
using Grpc.Core.Utils;
using Sales;
using OrderManagerStub = Sales.OrderManager.OrderManagerClient;

//expose REST based minimal API
public static class SalesAgent
{
    public static void AddSalesApi(this IServiceCollection services)
    {
        services.AddGrpcClient<OrderManagerStub>(channel => channel
            .Address = new Uri("http://localhost:4030"));
    }

    private static async Task<IResult> ReadOrders(string customerId, OrderManagerStub remote)
    {
        var request = new CustomerInput { CustomerCode = customerId };
        using var reply = remote.FetchOrders(request);
        var resources = from message in await reply.ResponseStream.ToListAsync()
                        select new OrderResource 
                        {
                            ProductNo = message.ItemCode,
                            Quantity = message.ItemCount,
                            OrderDate = message.ConfirmationDate
                        };
        return resources.Any() ? Results.Ok(resources) : Results.NotFound();
    }

    private static async Task<IResult> CreateOrder(OrderResource resource, OrderManagerStub remote)
    {
        var request = new OrderInput 
        {
            CustomerCode = resource.CustomerId,
            ItemCode = resource.ProductNo,
            ItemCount = resource.Quantity
        };
        try
        {
            var reply = await remote.PlaceOrderAsync(request);
            resource.OrderNo = reply.ConfirmationCode;
            return Results.Ok(resource);
        }
        catch(RpcException ex)
        {
            return Results.Problem(ex.Status.Detail, "CreateOrder", 500);
        }
    }

    public static void MapSalesApi(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/api/sales");
        group.MapGet("/{customerId}", ReadOrders);
        group.MapPost("/", CreateOrder);
        group.RequireCors(permissions => permissions
            .WithOrigins("http://localhost:5001")
            .AllowAnyMethod()
            .AllowAnyHeader());
    }
}
