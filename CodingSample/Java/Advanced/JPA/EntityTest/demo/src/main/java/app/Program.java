package app;

import app.tourism.models.SiteModel;

public class Program {
    
    public static void main(String[] args) throws Exception {
        var site = new SiteModel();
        if(args.length == 1){
            site.acceptVisit(args[0], 5);
            System.out.printf("Welcome %s%n", args[0]);
        }else{
            for(var visitor : site.getVisitors()){
                System.out.printf("%s\t%d\t%s%n", visitor.name(), visitor.visits(), visitor.recent());
            }
        }
    }
}

