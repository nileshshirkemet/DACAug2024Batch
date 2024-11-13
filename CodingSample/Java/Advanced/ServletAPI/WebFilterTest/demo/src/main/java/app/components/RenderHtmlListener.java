package app.components;

import java.io.File;

import jakarta.servlet.ServletContextEvent;
import jakarta.servlet.ServletContextListener;
import jakarta.servlet.annotation.WebListener;

@WebListener
public class RenderHtmlListener implements ServletContextListener {

    @Override
    public void contextInitialized(ServletContextEvent sce) {
        var context = sce.getServletContext();
        File check = new File("enable.html.rendering");
        if(check.exists()){
            var servlet = context.addServlet("renderHtml", new RenderingServlet());
            servlet.addMapping("*.html");
        }
    }
    
    
}
