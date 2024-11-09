package app.models;

import java.io.FileReader;
import java.io.IOException;
import java.util.Arrays;

import com.google.gson.Gson;

public class ShopModel {
    
    private ItemInfo[] items;

    private ShopModel() {}

    public static ShopModel build(){
        try(var reader = new FileReader("EviTek.store")){
            var gson = new Gson();
            var shop = new ShopModel();
            shop.items = gson.fromJson(reader, ItemInfo[].class);
            return shop;
        }catch(IOException e){
            e.printStackTrace();
            return null;
        }
    }

    public String getItemInfo(String name) {
        return Arrays.stream(items)
            .filter(i -> i.id().equals(name))
            .map(i -> i.toString())
            .findFirst()
            .orElse(null);
    }
}
