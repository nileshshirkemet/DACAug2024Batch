using System.Net.Sockets;

namespace DemoApp.Models;

public class ShopModel(string server)
{
    public async Task<ItemInfo> ReadItemInfoAsync(string name)
    {
        string url = $"http://{server}/shop/";
        using var client = new HttpClient{ BaseAddress = new Uri(url) };
        var response = await client.GetAsync(name);
        if(response.IsSuccessStatusCode)
        {
            string message = await response.Content.ReadAsStringAsync();
            return ItemInfo.Parse(message);
        }
        return default;
    }
}