namespace DemoApp.Models;

public readonly record struct ItemInfo(double Cost, int Stock)
{
    public static ItemInfo Parse(string message)
    {
        string[] segments = message.Split('&');
        double cost = double.Parse(segments[0][5..]);
        int stock = int.Parse(segments[1][6..]);
        return new ItemInfo(cost, stock);
    }
}