using System.Net;
using System.Net.Sockets;
using DemoApp.Models;

namespace DemoApp;

public class ShopWorker(int port, ShopModel model)
{
    public void Run()
    {
        //Step 1
        var listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        listener.Bind(new IPEndPoint(IPAddress.Any, port));
        listener.Listen();
        Console.WriteLine("Shop server started on TCP port {0}", port);
        while(true)
        {
            //Step 2
            var client = listener.Accept();
            //Step 3 and 4
            //Communicate(client);
            new Thread(() => Communicate(client)).Start();
        }
    }

    private void Communicate(Socket connection)
    {
        try
        {
            //Step 3
            var remote = new NetworkStream(connection);
            using var reader = new StreamReader(remote);
            using var writer = new StreamWriter(remote) { AutoFlush = true };
            writer.WriteLine("Welcome to EviTek Computers.");
            string name = reader.ReadLine();
            ItemInfo info = model.GetItemInfo(name);
            if(info != null)
                writer.WriteLine(info.ToString());
        }
        catch(Exception ex)
        {
            Console.WriteLine("Communication Failure: {0}", ex.Message);
        }
        //Step 4
        connection.Close();
    }
}