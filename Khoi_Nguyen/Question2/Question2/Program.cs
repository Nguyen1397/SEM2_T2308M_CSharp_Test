using Question2;

internal class Program
{
    private static void Main(string[] args)
    {
        Guitar_6 guitar1 = new Guitar_6();
        guitar1.GetInfo();

        Guitar_5 guitar2 = new Guitar_5();
        guitar2.GetInfo();

        Piano piano = new Piano();
        piano.GetInfo();

        Violin violin = new Violin();
        violin.GetInfo();

        ElectricalGuitar electricalGuitar = new ElectricalGuitar();
        electricalGuitar.GetInfo();

        Violin via = new Violin();
        via.GetInfo();
    }
}