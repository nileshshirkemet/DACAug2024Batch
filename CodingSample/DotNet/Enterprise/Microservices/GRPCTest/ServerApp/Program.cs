using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using ServerApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ShopDbContext>(options => options
    .UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False"));
builder.Services.AddGrpc(); //enable gRPC
var app = builder.Build();
app.MapGrpcService<OrderManagerService>();
//gRPC requires HTTP/2 endpoint so configure Kestrel
//to enable HTTP/2 protocol (see appsettings.json)
app.Run();
