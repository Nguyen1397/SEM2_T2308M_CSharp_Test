using Question1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("__A Normal Account__");
        NormalAccount normalAccount = new NormalAccount();
        normalAccount.Balance = 24000000;
        normalAccount.CheckBalance();
        Console.WriteLine("Enter money to transfer: ");
        int amount1 = Convert.ToInt32(Console.ReadLine());
        normalAccount.Transfer(amount1);

        Console.WriteLine("__An Exchanged Account__");
        ExchangedAccount exchangedAccount = new ExchangedAccount();
        exchangedAccount.Balance = 24000000;
        exchangedAccount.CheckBalance();
        Console.WriteLine("Enter money to transfer: ");
        int amount2 = Convert.ToInt32(Console.ReadLine());
        exchangedAccount.Transfer(amount2);
    }
}