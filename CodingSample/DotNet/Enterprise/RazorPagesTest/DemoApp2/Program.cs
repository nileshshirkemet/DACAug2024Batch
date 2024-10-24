using DemoApp.Data.Shopping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ShopDbContext>(options => options
    .UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User ID=dac;Password=Dac@1234;Encrypt=False"));
//configure authentication and authorization, 
//this also indicates that corresponding
//middlewares must be added to the pipeline
//if they are not explicitly used by the application
builder.Services.AddAuthentication()
    .AddCookie(options => options.LoginPath = "/Index");
var app = builder.Build();
app.MapRazorPages();
app.Run();
