package app.components;

import java.io.IOException;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

@WebServlet("/")
public class ShopControllerServlet extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        //response.sendRedirect("/index-view.jsp");
        request.getRequestDispatcher("/index-view.jsp").forward(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String customerId = request.getParameter("customerId");
        String password = request.getParameter("password");
        var model = new LoginModelBean();
        if(model.authenticate(customerId, password)){
            request.setAttribute("login", model);
            request.getRequestDispatcher("/detail-view.jsp").forward(request, response);
        }else{
            request.setAttribute("problem", "Invalid Customer ID or Password");
            request.getRequestDispatcher("/index-view.jsp").forward(request, response);
        }
    }
    
    
}
