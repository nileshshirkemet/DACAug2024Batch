using Taxation;

try
{
    string m = args[0].ToLower();
    int n = int.Parse(args[1]);
    DoAuditing(m, n);
}
catch(Exception ex)
{
    Console.WriteLine("Auditing failed: {0}", ex.Message);
}

void DoAuditing(string name, int count)
{
    Console.WriteLine("Auditing {0}...", name);
    ITaxPayer t = name == "jack" ? new Supervisor(count) : new Worker(count);
    //using statement ensures that Dispose() method of an IDisposable
    //type object is called before control leaves its scope
    using(Auditor a = new())
    {       
        a.Audit(name, t);
    }
}

class Auditor : IDisposable
{
    public Auditor()
    {
        Console.WriteLine("Auditor - acquiring required resources.");
    }

    public void Audit(string id, ITaxPayer info)
    {
        if(id.Length < 4)
            throw new ArgumentException("Invalid ID");
        decimal payment = info.IncomeTax() + 500;
        Console.WriteLine("Total Tax Payment: {0:0.00}", payment);
    }

    public void Dispose()
    {
        Console.WriteLine("Auditor - releasing acquired resources.");
    }
}