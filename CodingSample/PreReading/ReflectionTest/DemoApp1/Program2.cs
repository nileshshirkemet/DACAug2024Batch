using System.Reflection;

namespace DemoApp;

class Program
{
    static void Present(object info)
    {
        Type t = info.GetType();
        Console.WriteLine("<{0}>", t.Name);
        foreach(PropertyInfo p in t.GetProperties())
            Console.WriteLine("  <{0}>{1}</{0}>", p.Name, p.GetValue(info));
        Console.WriteLine("</{0}>", t.Name);
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        Present(Shop.FavoriteItem());
        Present(Shop.FavoriteCustomer());
    }
}
