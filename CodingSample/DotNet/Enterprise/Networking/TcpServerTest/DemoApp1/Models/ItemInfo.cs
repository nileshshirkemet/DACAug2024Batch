namespace DemoApp.Models;

public record ItemInfo(string Id, decimal Cost, int Stock)
{
    public override string ToString()
    {
        return string.Format("cost={0}&stock={1}", Cost, Stock);
    }
}