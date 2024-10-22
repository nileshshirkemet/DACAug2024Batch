using DemoApp.Services;
using Tourism.Models;

var builder = WebApplication.CreateBuilder(args);
//enable MVC route-mapping and razor-syntax
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICounter, CommonCounter>();
builder.Services.AddScoped<SiteModel>(); //one service object per request
var app = builder.Build();
//map path /X/Y to an action method with name Y published 
//by a Controller derived class with name XController
//with X=Home and Y=Index by default 
app.MapDefaultControllerRoute();
app.Run();
