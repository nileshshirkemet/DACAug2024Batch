namespace DemoApp.Middlewares;

public class Pausing(RequestDelegate next)
{
    private DateTime recent;

    public async Task Invoke(HttpContext context)
    {
        var current = DateTime.Now;
        if(current - recent > TimeSpan.FromSeconds(3))
        {
            await next.Invoke(context);
            recent = current;
        }
        else
            await context.Response.WriteAsync("Server is busy, please try after some time...");
    }
}