package app.components;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.concurrent.atomic.AtomicInteger;

import jakarta.servlet.ServletException;
//import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

//@WebServlet("*.html")
public class RenderingServlet extends HttpServlet {

    private AtomicInteger greetings = new AtomicInteger();

    @Override
    protected void service(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        var context = getServletContext();
        String page = request.getServletPath();
        String doc = context.getRealPath(page);
        String person = request.getParameter("user");
        if(person == null || person.length() == 0)
            person = "Friend";
        int count = greetings.getAndIncrement();
        try{
            String content = Files.readString(Path.of(doc))
                .replace("|visitorName|", person)
                .replace("|greetCount|", String.valueOf(count));
            response.setContentType("text/html");
            response.getWriter().println(content);
        }catch(FileNotFoundException e){
            response.sendError(404);
        }
    }
    
    
}
