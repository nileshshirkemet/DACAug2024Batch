namespace DemoApp.Endpoints;

public class Greeting
{
    public static async Task Welcome(HttpResponse response)
    {
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Welcome Visitor</h1>
                    <p>
                        <b>Current Time: </b>{DateTime.Now}
                    </p>
                    <form method="POST" action="Login">
                        <b>Name:</b>
                        <input type="text" name="user"/>
                        <input type="submit" value="Log In"/>
                    </form>
                </body>
            </html>
            """);
    }

    public static async Task Hello(HttpRequest request, HttpResponse response)
    {
        string person = request.Form["user"];
        int ticket = Random.Shared.Next(100000, 1000000);
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>DemoApp</title>
                </head>
                <body>
                    <h1>Hello {person}</h1>
                    <p>
                        <b>Ticket Number: </b>{ticket}
                    </p>
                </body>
            </html> 
            """
        );
    }
}
