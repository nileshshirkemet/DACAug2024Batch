using DemoApp;
using DemoApp.Models;

var app = new ShopWorker(4000, new ShopModel());
app.Run();