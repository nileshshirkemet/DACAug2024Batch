using DemoApp.Resources;

var builder = WebApplication.CreateBuilder(args);
//by default a web-browser enforces 'same-origin policy' meaning
//a client side code can only render a resource it aquires from its 
//own http endpoint unless server of that resource enables 
//cross origin resource sharing (CORS) by sending appropriate headers
//to the browser
builder.Services.AddCors();
builder.Services.AddSalesApi();
var app = builder.Build();
app.UseCors(); //send CORS header required by an endpoint
app.UseFileServer();
app.MapSalesApi();
app.Run();
