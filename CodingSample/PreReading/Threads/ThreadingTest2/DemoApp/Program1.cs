class Program
{
    class JointAccount
    {
        public int Balance { get; private set; }

        public bool Withdraw(int amount)
        {
            bool success = false;
            if(Balance >= amount)
            {
                Balance = Activity.Perform(Balance, amount);
                success = true;
            }
            return success;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }

    static void Main(string[] args)
    {
        var acc = new JointAccount();
        acc.Deposit(10000);
        Console.WriteLine("Joint-Account opened for Jack and Jill.");
        Console.WriteLine($"Initial Balance: {acc.Balance}");
        Console.WriteLine("Jack is withdrawing 6000...");
        if(!acc.Withdraw(6000))
            Console.WriteLine("Jack's withdrawal failed!");
        Console.WriteLine("Jill is withdrawing 7000...");
        if(!acc.Withdraw(7000))
            Console.WriteLine("Jill's withdrawal failed!");
        Console.WriteLine($"Final Balance : {acc.Balance}");
    }
}