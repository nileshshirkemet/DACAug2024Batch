namespace DemoApp.Services;

public class NamedCounter : ICounter
{
    private static Dictionary<string, int> store = new();

    public int CountNext(string id)
    {
        lock(store)
        {
            store.TryGetValue(id, out int current);
            store[id] = ++current;
            return current;
        }    
    }
}