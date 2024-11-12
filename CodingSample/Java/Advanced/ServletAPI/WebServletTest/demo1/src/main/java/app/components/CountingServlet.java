package app.components;

import java.io.IOException;
import java.util.concurrent.atomic.AtomicInteger;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/login")
public class CountingServlet extends HttpServlet {

    private AtomicInteger greetings = new AtomicInteger();

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String person = request.getParameter("user");
        if(person.length() == 0)
            person = "Friend";
        var session = request.getSession(true);
        var count = (Integer)session.getAttribute(person);
        if(count == null)
            count = 0;
        response.setContentType("text/html");
        response.getWriter().printf("""
            <html>
                <head>
                    <title>demo-app</title>
                </head>
                <h1>Hello %s</h1>
                <b>Number of Greetings: </b>%d/%d
            </html>
            """, person, ++count, greetings.incrementAndGet());
            session.setAttribute(person, count);
    }
    
    
}
