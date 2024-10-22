using DemoApp.Endpoints;
using DemoApp.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<ICounter, CommonCounter>();
builder.Services.AddTransient<ICounter, NamedCounter>();
var app = builder.Build();
app.Map("/Home", Greeting.Welcome);
app.Run();
