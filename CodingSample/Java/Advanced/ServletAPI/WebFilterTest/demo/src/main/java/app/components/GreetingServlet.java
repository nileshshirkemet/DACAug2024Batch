package app.components;

import java.io.IOException;
import java.util.Date;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/greet/*")
public class GreetingServlet extends HttpServlet {

    @Override
    public void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String info = request.getPathInfo();
        String person = info != null ? info.substring(1) : "Visitor";
        response.setContentType("text/html");
        response.getWriter().printf("""
            <html>
                <head>
                    <title>demo-app</title>
                </head>
                <body>
                    <h1>Welcome %s</h1>
                    <b>Current Time: </b>%s
                </body>
            </html>
            """, person, new Date());
    }
}
