//C# supports top-level statements which are copied into 
//the Main method of an auto-generated Program class at
//compile time. Such statements may only appear in one
//source file of a project with output type as Exe


Interval a = new Interval(6, 65);
Interval b = new Interval(4, 30);
Print("Interval a", a);
Print("Interval b", b);
Print("Sum", a + b);//Interval.operator+(a, b)
Interval c = new Interval(7, 5);
Print("Interval c", c);
Interval d = b;
Print("Interval d", d);
Console.WriteLine("------------------------------------");
Console.WriteLine("a is identical to b: {0}", ReferenceEquals(a, b));
Console.WriteLine("a is identical to c: {0}", ReferenceEquals(a, c));
Console.WriteLine("d is identical to b: {0}", ReferenceEquals(d, b));
Console.WriteLine("------------------------------------");
Console.WriteLine("a is equal to b: {0}", Equals(a, b));
Console.WriteLine("a is equal to c: {0}", Equals(a, c));
Console.WriteLine("d is equal to b: {0}", Equals(d, b));
Console.WriteLine("------------------------------------");
Plot e = new Plot { Length = 40.75, Breadth = 36.25 }; //using instance initializer 
Print("Plot e", e); //auto-boxing of value type(Plot) to compatible reference type(object)


//Print is local function of Main method,
//such functions cannot be overloaded
void Print(string label, object info)
{
    Console.WriteLine("{0} = {1}", label, info);
}
