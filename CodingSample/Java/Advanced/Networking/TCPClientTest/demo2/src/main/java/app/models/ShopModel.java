package app.models;

import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;

public class ShopModel {
    
    private String server;

    public ShopModel(String server) {
        this.server = server;
    }

    public ItemInfo readItemInfo(String name) throws Exception {
        URI address = URI.create("http://" + server + "/shop/" + name);
        var client = HttpClient.newHttpClient();
        var request = HttpRequest.newBuilder(address)
            .GET()
            .header("User-Agent", "SalesClient/1.0")
            .header("Accept", "text/plain")
            .build();
        var response = client.send(request, HttpResponse.BodyHandlers.ofString());
        if(response.statusCode() == 200){
            String message = response.body();
            return ItemInfo.parse(message);
        }
        return new ItemInfo(0, 0);
    }
    
}
