using System.Net.Sockets;

namespace DemoApp.Models;

public class ShopModel(string server)
{
    public async Task<ItemInfo> ReadItemInfoAsync(string name)
    {
        //Step 1
        var connection = new TcpClient(server, 4000);
        //Step 2
        var remote = connection.GetStream();
        using var reader = new StreamReader(remote);
        using var writer = new StreamWriter(remote) { AutoFlush = true };
        await reader.ReadLineAsync(); //read greeting message
        await writer.WriteLineAsync(name);
        string message = await reader.ReadLineAsync();
        //Step 3
        connection.Close();
        if(message != null)
            return ItemInfo.Parse(message);
        return default;
    }
}