package app.models;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.Properties;

public class ShopModel {
    
    private Properties items = new Properties();

    private ShopModel() {}

    public static ShopModel build(){
        try(var input = new FileInputStream("EviTek.store")){
            var shop = new ShopModel();
            shop.items.loadFromXML(input);
            return shop;
        }catch(IOException e){
            return null;
        }
    }

    public String getItemInfo(String name) {
        return items.getProperty(name);
    }
}
