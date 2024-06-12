namespace DIP_DI_Pttern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer(new FileLogger());
            dataAccessLayer.AddCustomer("nam");
        }
    }
}
