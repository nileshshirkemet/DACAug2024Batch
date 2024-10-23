using Tourism.Models;

var builder = WebApplication.CreateBuilder(args);
//Razor views are not required for client-side rendering
builder.Services.AddControllers();
builder.Services.AddScoped<SiteModel>();
var app = builder.Build();
app.UseDefaultFiles(); //make wwwroot/index.html default page
app.UseStaticFiles();
app.UseRouting();
app.MapControllers(); //enable attribute based route-mapping
app.Run();
