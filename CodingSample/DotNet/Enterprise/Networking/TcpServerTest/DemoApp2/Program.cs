using DemoApp;
using DemoApp.Models;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<ShopWorker>();
builder.Services.AddTransient<ShopModel>();
var app = builder.Build();
app.Run();
