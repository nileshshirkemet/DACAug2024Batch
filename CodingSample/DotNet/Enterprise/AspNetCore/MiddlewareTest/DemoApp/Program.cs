using DemoApp.Endpoints;
using DemoApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options => options
    .IdleTimeout = TimeSpan.FromMinutes(5)
);
var app = builder.Build();
app.UseSession();
app.UseStaticFiles(); //output *.html from ~/wwwroot directory
app.UseMiddleware<Pausing>();
app.MapGet("/Home", Greeting.Welcome);
app.MapPost("/Login", Greeting.Hello);
app.Run();
