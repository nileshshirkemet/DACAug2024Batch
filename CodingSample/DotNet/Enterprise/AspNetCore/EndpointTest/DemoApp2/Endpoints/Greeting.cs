using DemoApp.Services;

namespace DemoApp.Endpoints;

public class Greeting
{
    public static async Task Welcome(HttpContext context, ICounter counter)
    {
        string person = "Visitor";
        if(context.Request.Method == "POST")
            person = context.Request.Form["user"];
        await context.Response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Welcome {person}</h1>
                    <p>
                        <b>Number of Greetings: </b>{counter.CountNext(person)}
                    </p>
                    <form method="POST">
                        <b>Name:</b>
                        <input type="text" name="user"/>
                        <input type="submit" value="Log In"/>
                    </form>
                </body>
            </html>
            """);
    }
}
