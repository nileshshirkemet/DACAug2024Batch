package app.components;

import java.io.IOException;

import com.google.gson.Gson;

import app.tourism.models.SiteModel;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/api/site")
public class SiteManagerServlet extends HttpServlet {
    
    static class VisitorInput {
        String id;
        int rating;
    }

    SiteModel model = new SiteModel();

    Gson gson = new Gson();

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        var visitors = model.getVisitors();
        response.setContentType("application/json");
        gson.toJson(visitors, response.getWriter());
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        var visitor = gson.fromJson(request.getReader(), VisitorInput.class);
        if(!model.acceptVisit(visitor.id, visitor.rating))
            response.sendError(400, "Invalid input");
    }

    
}
