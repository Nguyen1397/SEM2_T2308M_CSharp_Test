// See https://aka.ms/new-console-template for more information
using DIP;

internal class Program
{
   public static void Main(string[] args)
    {
        DataAccessLayer dataAccess = new DataAccessLayer(new FileLogger());
        dataAccess.Addcustomer("Nam");
    }
}
