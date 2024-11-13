package app.components;

import java.io.IOException;

import jakarta.servlet.Filter;
import jakarta.servlet.FilterChain;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;
import jakarta.servlet.annotation.WebFilter;

@WebFilter("/*")
public class PausingFilter implements Filter {
    
    private long recent = 0;

    @Override
    public void doFilter(ServletRequest request, ServletResponse response, FilterChain next) throws IOException, ServletException {
        long now = System.currentTimeMillis();
        if(now - recent >= 5000){
            next.doFilter(request, response);
            recent = now;
        }else{
            response.getWriter().println("Server busy, try after some time...");
        }
    }

    
}
