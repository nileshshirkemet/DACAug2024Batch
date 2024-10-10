if(args.Length > 0 && int.TryParse(args[0], out int choice))
{
    Console.WriteLine("Selected double value   = {0}", Select(choice, 43.1, 34.2));
    Console.WriteLine("Selected string value   = {0}", Select(choice, "Monday", "Tuesday"));
    //Console.WriteLine("Selected rotten value   = {0}", Select(choice, "Apple", 9.8));
}
else
{
    Console.WriteLine("Selected double value   = {0}", Select(43.1, 34.2));
    Console.WriteLine("Selected string value   = {0}", Select("Monday", "Tuesday"));
    Console.WriteLine("Selected Interval value = {0}", Select(new Interval(4, 5), new Interval(3, 45)));
   
}

//Same type can be declared multiple times in a project 
//using 'partial' keyword to define different members of
//that type. Compile-time auto-generated type is declared
//as partial type in order to allow definitions for 
//additional members.
partial class Program
{
    //generic method with T as type-parameter
    static T Select<T>(int index, T first, T second)
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

    static T Select<T>(T first, T second) where T: IComparable<T>
    {
        if(first.CompareTo(second) > 0)
            return first;
        return second;
    }
}
