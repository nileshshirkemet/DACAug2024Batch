namespace DemoApp.Endpoints;

public class Greeting
{
    public static async Task Welcome(HttpResponse response, string person="Visitor")
    {
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Welcome {person}</h1>
                    <p>
                        <b>Current Time: </b>{DateTime.Now}
                    </p>
                </body>
            </html>
            """);
    }

    public static async Task Hello(HttpContext context)
    {
        string person = context.Request.Form["user"];
        int count = context.Session.GetInt32(person) ?? 1;
        await context.Response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Hello {person}</h1>
                    <p>
                        <b>Number of Greetings: </b>{count}
                    </p>
                </body>
            </html> 
            """
        );
        context.Session.SetInt32(person, count + 1);
    }
}
