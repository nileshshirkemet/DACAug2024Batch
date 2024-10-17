using System.Text.Json;

namespace DemoApp.Models;

public class ShopModel
{
    private ItemInfo[] items;

    public ShopModel()
    {
        using var input = new FileStream("EviTek.store", FileMode.Open);
        //converting a series of bytes int an object is called object deserialization
        items = JsonSerializer.Deserialize<ItemInfo[]>(input);
    }

    public virtual ItemInfo GetItemInfo(string name)
    {
        return items.FirstOrDefault(i => i.Id == name);
    }

    public virtual void Save()
    {
        using var output = new FileStream("EviTek.store", FileMode.Create);
        //converting object into series of bytes is called object serialization 
        JsonSerializer.Serialize(output, items);
    }
}