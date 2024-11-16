package app;

import java.io.File;
import org.apache.catalina.startup.Tomcat;

public class Program {
    
    public static void main(String[] args) throws Exception {
        String dir = System.getProperty("java.io.tmpdir");
        var tomcat = new Tomcat();
        tomcat.setPort(Integer.parseInt(System.getProperty("server.http.port", "5000")));
        tomcat.setBaseDir(dir);
        tomcat.getHost().setAppBase(dir);
        tomcat.addWebapp("", new File("target/deploy.war").getAbsolutePath());
        Runtime.getRuntime().addShutdownHook(new Thread(() -> {
            try{
                tomcat.stop();
                tomcat.destroy();
            }catch(Exception e){}
        }));
        tomcat.getConnector();
        tomcat.start(); 
        tomcat.getServer().await(); 
    }
}

