package app;

import app.shopping.data.ProductEntity;
import jakarta.persistence.Persistence;

public class Program {
    
    public static void main(String[] args) throws Exception {
        var emf = Persistence.createEntityManagerFactory("app.data");
        var em = emf.createEntityManager();
        if(args.length == 0){
            var products = em.createNamedQuery("findBigProducts", ProductEntity.class)
                .setParameter(1, 20)
                .getResultList();
            for(var item : products)
                System.out.printf("%-6d%12.2f%8d%n", item.getProductNo(), item.getPrice(), item.getStock());
            
        }else{
            int pno = Integer.parseInt(args[0]);
            var product = em.find(ProductEntity.class, pno);
            if(product != null){
                for(var order : product.getOrders()){
                    System.out.printf("%s\t%d\t%s%n", order.getCustomerId(), order.getQuantity(), order.orderDateAsString());
                }
            }
        }
        em.close();
    }
}

